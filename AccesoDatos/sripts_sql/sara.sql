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


CREATE VIEW v_citas AS
SELECT 
    c.id_cita AS Id_Cita,
    c.fkid_paciente	AS Id_Paciente,
    c.fkid_personal as Id_Personal,
    p.curp as CURP,
    p.nombre_completo AS Paciente,
    c.fecha_hora AS Fecha_Hora,
    CONCAT('Dr. ', per.nombre, ' ', per.apellido,' (', per.especialidad, ')') AS Medico_Asignado,
    c.motivo AS Motivo,
    c.estado AS Estado
FROM tbl_citas c
INNER JOIN tbl_pacientes p   ON c.fkid_paciente = p.id_paciente
INNER JOIN tbl_personal  per ON c.fkid_personal = per.id_personal;

CREATE PROCEDURE p_insertar_cita(
    IN p_fkid_paciente INT,
    IN p_fkid_personal INT,
    IN p_fecha_hora    DATETIME,
    IN p_motivo        TEXT
)
BEGIN
    IF (SELECT activo FROM tbl_pacientes WHERE id_paciente = p_fkid_paciente) = 0 THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'El paciente está inactivo, no se puede registrar la cita.';
    ELSE
        INSERT INTO tbl_citas (fkid_paciente, fkid_personal, fecha_hora, estado, motivo)
        VALUES (p_fkid_paciente, p_fkid_personal, p_fecha_hora, 'Programada', p_motivo);
    END IF;
END

CREATE PROCEDURE p_editar_cita(
    IN p_id_cita       INT,
    IN p_fkid_paciente INT,
    IN p_fkid_personal INT,
    IN p_fecha_hora    DATETIME,
    IN p_estado        ENUM('Programada','Atendida','Cancelada','No_asistio'),
    IN p_motivo        TEXT
)
BEGIN
    UPDATE tbl_citas
    SET fkid_paciente = p_fkid_paciente,
        fkid_personal = p_fkid_personal,
        fecha_hora    = p_fecha_hora,
        estado        = p_estado,
        motivo        = p_motivo
    WHERE id_cita = p_id_cita;
END

create view v_CmbMedico as
select p.id_personal,
concat('Dr. ',p.nombre, ' ' ,p.apellido, ' (' ,p.especialidad, ')') as Medico
from tbl_personal p
where p.fkid_rol = 2;
