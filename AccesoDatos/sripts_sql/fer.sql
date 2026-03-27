CREATE VIEW v_personal AS
SELECT 
    p.id_personal,
    p.nombre,
    p.apellido,
    CONCAT(p.nombre, ' ', p.apellido) AS nombre_completo,
    p.telefono,
    p.correo,
    p.especialidad,
    p.estado,
    p.fkid_rol,
    r.nombre_rol
FROM tbl_personal p
INNER JOIN tbl_roles r ON p.fkid_rol = r.id_rol;


DELIMITER $$
CREATE PROCEDURE sp_buscar_personal(IN p_busqueda VARCHAR(100))
BEGIN
    SELECT * FROM v_personal
    WHERE 
        (p_busqueda IS NULL OR TRIM(p_busqueda) = '') 
        OR nombre_completo LIKE CONCAT('%', p_busqueda, '%')
    ORDER BY nombre ASC;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE sp_agregar_personal(
    IN p_nombre       VARCHAR(100),
    IN p_apellido     VARCHAR(100),
    IN p_telefono     VARCHAR(15),
    IN p_correo       VARCHAR(100),
    IN p_especialidad VARCHAR(100),
    IN p_estado       ENUM('Activo','Inactivo'),
    IN p_fkid_rol     INT
)
BEGIN
    INSERT INTO tbl_personal (nombre, apellido, telefono, correo, especialidad, estado, fkid_rol)
    VALUES (p_nombre, p_apellido, p_telefono, p_correo, p_especialidad, p_estado, p_fkid_rol);

    SELECT * FROM v_personal WHERE id_personal = LAST_INSERT_ID();
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE sp_editar_personal(
    IN p_id_personal  INT,
    IN p_nombre       VARCHAR(100),
    IN p_apellido     VARCHAR(100),
    IN p_telefono     VARCHAR(15),
    IN p_correo       VARCHAR(100),
    IN p_especialidad VARCHAR(100),
    IN p_estado       ENUM('Activo','Inactivo'),
    IN p_fkid_rol     INT
)
BEGIN
    UPDATE tbl_personal SET
        nombre       = p_nombre,
        apellido     = p_apellido,
        telefono     = p_telefono,
        correo       = p_correo,
        especialidad = p_especialidad,
        estado       = p_estado,
        fkid_rol     = p_fkid_rol
    WHERE id_personal = p_id_personal;

    SELECT * FROM v_personal WHERE id_personal = p_id_personal;
END $$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE sp_eliminar_personal(IN p_id_personal INT)
BEGIN
    IF EXISTS (
        SELECT 1 FROM tbl_citas 
        WHERE fkid_personal = p_id_personal 
          AND estado = 'Programada'
    ) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'No se puede eliminar: el personal tiene citas programadas.';
    ELSE
        DELETE FROM tbl_personal WHERE id_personal = p_id_personal;
    END IF;
END $$
DELIMITER ;