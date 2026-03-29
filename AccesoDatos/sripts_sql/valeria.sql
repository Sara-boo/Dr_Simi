
---------------------  PROCEDIMIENTOS
--Procedimiento para validar Inicio de Sesion

DROP PROCEDURE IF EXISTS p_ValidarLogin;
CREATE PROCEDURE p_ValidarLogin(
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(255)
)
BEGIN
    DECLARE x INT DEFAULT 0;
    
    SELECT COUNT(*) INTO x FROM tbl_usuarios WHERE BINARY username = p_username AND password = p_password;
    
    IF x > 0 THEN 
        SELECT 'Ac3ptad0' AS rs;
    ELSE
        SELECT 'Error' AS rs;
    END IF;
END;

-- Procedimiento para Insertar un nuevo Usuario
DROP PROCEDURE IF EXISTS p_InsertarUsuario;
CREATE PROCEDURE p_InsertarUsuario(
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(255),
    IN p_activo BOOLEAN,
    IN p_fkid_personal INT
)
BEGIN
    DECLARE _existe INT DEFAULT 0;
    
    SELECT COUNT(*) INTO _existe 
    FROM tbl_usuarios WHERE username = p_username;
    
    IF _existe = 0 THEN
        INSERT INTO tbl_usuarios (username, password, activo, fkid_personal) 
        VALUES (p_username, p_password, p_activo, p_fkid_personal);
        
        SELECT 'Insertado' AS msg;
    ELSE
        SELECT 'Ya existe un usuario con el mismo nombre. Escriba otro nombre de Usuario' AS msg;
    END IF;
END;

-- Procedimeinto para Editar los datos del Usuario
DROP PROCEDURE IF EXISTS p_EditarUsuario;
CREATE PROCEDURE p_EditarUsuario(
    IN p_id_usuario INT,
    IN p_username VARCHAR(50),
    IN p_password VARCHAR(255),
    IN p_activo BOOLEAN, 
    IN p_fkid_personal INT
)
BEGIN
    UPDATE tbl_usuarios
    SET 
        username      = p_username,
        password      = SHA1(p_password),
        activo        = p_activo,
        fkid_personal = p_fkid_personal
    WHERE id_usuario = p_id_usuario;
END;

-- Procedimiento para ver el Estado
DROP PROCEDURE IF EXISTS p_EstadoUsuario;
CREATE PROCEDURE p_EstadoUsuario(
    IN p_id_usuario INT
)
BEGIN
    UPDATE tbl_usuarios
    SET activo = NOT activo
    WHERE id_usuario = p_id_usuario;
END;



--------------------- VISTAS

---Vista para obtener el Nombre del Usuario que Inicie Sesion

DROP VIEW IF EXISTS v_NombreUsuario;
CREATE VIEW v_NombreUsuario AS
SELECT 
    u.username,
    CONCAT(p.nombre, ' ', p.apellido) AS nombre_completo
FROM tbl_usuarios u
INNER JOIN tbl_personal p ON u.fkid_personal = p.id_personal;


-- Vista para Ver Usuarios
CREATE OR REPLACE VIEW v_usuarios AS
SELECT 
    u.id_usuario,
    u.username        AS 'Usuario',
    u.fkid_personal   AS id_personal,
    CONCAT(p.nombre, ' ', p.apellido) AS 'Nombre Completo',
    r.nombre_rol      AS 'Rol',
    u.password,
    u.activo          AS 'Estatus',
    u.created_at,
    u.updated_at
FROM tbl_usuarios u
INNER JOIN tbl_personal p ON u.fkid_personal = p.id_personal
INNER JOIN tbl_roles r ON p.fkid_rol = r.id_rol
ORDER BY u.activo DESC;
