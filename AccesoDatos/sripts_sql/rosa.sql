CREATE OR REPLACE VIEW v_pacientes_activos AS
SELECT 
    id_paciente AS ID, 
    nombre_completo AS Nombre, 
    curp AS CURP,
    TIMESTAMPDIFF(YEAR, fecha_nacimiento, CURDATE()) AS Edad,
    sexo AS Sexo, 
    tipo_sangre AS Sangre, 
    enfermedades_cronicas AS 'Enf. Crónicas',
    alergias AS Alergias, 
    direccion AS Dirección, 
    correo AS Correo, 
    telefono AS Teléfono
FROM tbl_pacientes
WHERE activo = true;