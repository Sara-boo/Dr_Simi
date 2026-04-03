
CREATE VIEW v_citas AS
SELECT 
    c.id_cita AS Id_Cita,
    c.fkid_paciente	AS Id_Paciente,
    c.fkid_personal as Id_Personal,
    p.curp as CURP,
    p.nombre_completo AS Paciente,
    c.fecha_hora AS Fecha_Hora,
    CONCAT('Dr. ', per.nombre, ' ', per.apellido,' (', per.especialidad, ')') AS Medico_Asignado,
    c.estado AS Estado
FROM tbl_citas c
INNER JOIN tbl_pacientes p   ON c.fkid_paciente = p.id_paciente
INNER JOIN tbl_personal  per ON c.fkid_personal = per.id_personal;

CREATE PROCEDURE p_insertar_cita(
    IN p_fkid_paciente INT,
    IN p_fkid_personal INT,
    IN p_fecha_hora    DATETIME
)
BEGIN
    if (SELECT activo from tbl_pacientes WHERE id_paciente = p_fkid_paciente) = 0 THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'El paciente está inactivo, no se puede registrar la cita.';
    else
        INSERT INTO tbl_citas (fkid_paciente, fkid_personal, fecha_hora, estado)
        values (p_fkid_paciente, p_fkid_personal, p_fecha_hora, 'Programada');
    END IF;
END

CREATE PROCEDURE p_editar_cita(
    IN p_id_cita       INT,
    IN p_fkid_paciente INT,
    IN p_fkid_personal INT,
    IN p_fecha_hora    DATETIME,
    IN p_estado ENUM('Programada','Atendida','Cancelada','No_asistio')
)
begin
    update tbl_citas
    set fkid_paciente = p_fkid_paciente,
        fkid_personal = p_fkid_personal,
        fecha_hora    = p_fecha_hora,
        estado        = p_estado
    WHERE id_cita = p_id_cita;
END

create view v_CmbMedico as
select p.id_personal,
concat('Dr. ',p.nombre, ' ' ,p.apellido, ' (' ,p.especialidad, ')') as Medico
from tbl_personal p
where p.fkid_rol = 2;
