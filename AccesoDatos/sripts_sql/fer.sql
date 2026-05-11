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

DROP PROCEDURE IF EXISTS sp_buscar_personal;
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

DROP PROCEDURE IF EXISTS sp_agregar_personal;
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

DROP PROCEDURE IF EXISTS sp_editar_personal;
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

DROP PROCEDURE IF EXISTS sp_eliminar_personal;

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
        DELETE FROM tbl_usuarios WHERE fkid_personal = p_id_personal;
        
        DELETE FROM tbl_horarios WHERE fkid_personal = p_id_personal;
        
        DELETE FROM tbl_personal WHERE id_personal = p_id_personal;
    END IF;
END $$
DELIMITER ;

-- Vista para mostrar las citas
CREATE VIEW v_citas AS
SELECT 
    p.nombre_completo                                        AS Paciente,
    c.fecha_hora                                             AS Fecha_Hora,
    CONCAT('Dr. ', per.nombre, ' ', per.apellido, 
           ' (', per.especialidad, ')')                      AS Medico_Asignado,
    c.motivo                                                 AS Observaciones,
    c.estado                                                 AS Estado
FROM tbl_citas c
INNER JOIN tbl_pacientes p   ON c.fkid_paciente = p.id_paciente
INNER JOIN tbl_personal  per ON c.fkid_personal = per.id_personal;



CREATE OR REPLACE VIEW v_catalogo_vacunas AS
SELECT 
    i.id_inventario, 
    CONCAT(m.nombre, ' (Lote: ', i.lote, ' - Stock: ', i.stock_actual, ')') AS nombre_vacuna
FROM tbl_inventario i
INNER JOIN tbl_medicamentos m ON i.fkid_medicamento = m.id_medicamento
WHERE m.tipo = 'Vacuna' 
  AND i.stock_actual > 0 
  AND i.estatus = 'Activo';
  
-- Para guardar la vacuna --

DROP PROCEDURE IF EXISTS p_registrar_vacunacion;

DELIMITER $$
CREATE PROCEDURE p_registrar_vacunacion(
    IN p_id_inventario INT,
    IN p_id_usuario INT
)
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Error al registrar la vacunación';
    END;

    START TRANSACTION;

    -- 1. Insertar registro de vacunación
    INSERT INTO tbl_registro_vacunacion (fkid_inventario) 
    VALUES (p_id_inventario);

    -- 2. Restar 1 al stock
    UPDATE tbl_inventario 
    SET stock_actual = stock_actual - 1 
    WHERE id_inventario = p_id_inventario;

    -- 3. Movimiento sin usuario (NULL es válido)
    INSERT INTO tbl_movimientos_inventario (fkid_inventario, tipo_movimiento, cantidad, motivo)
    VALUES (p_id_inventario, 'Salida', 1, 'Aplicación de Vacuna');

    -- 4. Marcar agotado si llegó a 0
    UPDATE tbl_inventario 
    SET estatus = 'Agotado' 
    WHERE id_inventario = p_id_inventario AND stock_actual <= 0;

    COMMIT;
END $$
DELIMITER ;
--
