-- Procedimientos almacenados para la tabla tbl_usuarios
CREATE PROCEDURE p_insertar_usuario(
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(255),
    IN p_fkid_personal INT )
BEGIN
    INSERT INTO tbl_usuarios (username, password, fkid_personal)
    VALUES (p_username, SHA1(p_password), p_fkid_personal);
END 


CREATE PROCEDURE p_editar_usuario(
    IN p_id_usuario INT,
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(255),
    IN p_fkid_personal INT
)
BEGIN
    UPDATE tbl_usuarios
    SET 
        username      = p_username,
        password      = SHA1(p_password),
        fkid_personal = p_fkid_personal
    WHERE id_usuario = p_id_usuario;
END 

CREATE PROCEDURE p_estado_usuario(
    IN p_id_usuario INT
)
BEGIN
    UPDATE tbl_usuarios
    SET activo = NOT activo
    WHERE id_usuario = p_id_usuario;
END

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