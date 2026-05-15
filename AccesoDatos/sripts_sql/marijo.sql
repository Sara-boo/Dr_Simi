--Para insertar medicamentos
DELIMITER $$
DROP PROCEDURE IF EXISTS p_registrar_medicamentos;
CREATE PROCEDURE p_registrar_medicamentos(
IN p_nombre VARCHAR(120),
IN p_descripcion TEXT,
IN p_tipo ENUM('Medicamento','Vacuna'),
IN p_presentacion VARCHAR(50),
IN p_concentracion VARCHAR(50),
IN p_requiere_receta BOOLEAN )

BEGIN
INSERT INTO tbl_medicamentos(
nombre,descripcion,tipo,presentacion,concentracion,requiere_receta) VALUES(p_nombre,p_descripcion,p_tipo,p_presentacion,p_concentracion,p_requiere_receta);

END$$
DELIMITER;

--Para registrar la entrada en el inventario
DELIMITER $$

DROP PROCEDURE IF EXISTS p_registrar_entrada_inventario$$

CREATE PROCEDURE p_registrar_entrada_inventario(
    IN p_fkid_medicamento INT,
    IN p_lote VARCHAR(50),
    IN p_fecha_caducidad DATE,
    IN p_cantidad INT,
    IN p_stock_minimo INT,
    IN p_ubicacion VARCHAR(100),
    IN p_id_usuario INT 
)
BEGIN
    DECLARE v_id_inventario INT DEFAULT NULL;

    SELECT id_inventario INTO v_id_inventario 
    FROM tbl_inventario 
    WHERE fkid_medicamento = p_fkid_medicamento AND lote = p_lote 
    LIMIT 1;

    IF v_id_inventario IS NOT NULL THEN

        UPDATE tbl_inventario 
        SET stock_actual = stock_actual + p_cantidad
        WHERE id_inventario = v_id_inventario;
    ELSE

        INSERT INTO tbl_inventario (fkid_medicamento, lote, fecha_caducidad, stock_actual, stock_minimo, ubicacion)
        VALUES (p_fkid_medicamento, p_lote, p_fecha_caducidad, p_cantidad, p_stock_minimo, p_ubicacion);

        SET v_id_inventario = LAST_INSERT_ID();
    END IF;

    INSERT INTO tbl_movimientos_inventario (fkid_inventario, tipo_movimiento, cantidad, motivo, fkid_usuario)
    VALUES (v_id_inventario, 'Entrada', p_cantidad, CONCAT('Registro de entrada lote: ', p_lote), p_id_usuario);

END$$

DELIMITER ;

--Modifiqué tbl_tratamiento y agregué la tabla tbl_detalle_tratamiento para registrar los medicamentos asociados a cada tratamiento, ya que un tratamiento puede incluir varios medicamentos y un medicamento puede ser parte de varios tratamientos.
CREATE TABLE tbl_tratamiento (
    id_tratamiento INT AUTO_INCREMENT PRIMARY KEY,
    fkid_historial INT NOT NULL,
    descripcion_sintomas TEXT, 
    fecha_registro DATETIME DEFAULT CURRENT_TIMESTAMP,
    fkid_usuario INT, 
    FOREIGN KEY (fkid_historial) REFERENCES tbl_historial_clinico(id_historial),
    FOREIGN KEY (fkid_usuario) REFERENCES tbl_usuarios(id_usuario),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

CREATE TABLE tbl_detalle_tratamiento (
    id_detalle INT AUTO_INCREMENT PRIMARY KEY,
    fkid_tratamiento INT NOT NULL, 
    fkid_medicamento INT NOT NULL,
    cantidad INT, 
    dosis VARCHAR(100),
    frecuencia VARCHAR(100),
    duracion VARCHAR(100),
    FOREIGN KEY (fkid_tratamiento) REFERENCES tbl_tratamiento(id_tratamiento),
    FOREIGN KEY (fkid_medicamento) REFERENCES tbl_medicamentos(id_medicamento)
);

--Para registrar la salida de medicamentos (receta)
DELIMITER $$
CREATE PROCEDURE p_registrar_salida_inventario(
IN p_fkid_medicamento INT,
IN p_cantidad INT,
IN p_fkid_usuario INT,
IN p_motivo VARCHAR(255))
BEGIN
	DECLARE v_id_inventario INT;
	DECLARE v_stock_actual INT;
	
	SELECT id_inventario, stock_actual INTO v_id_inventario, v_stock_actual FROM tbl_inventario WHERE fkid_medicamento = p_fkid_medicamento AND stock_actual >= p_cantidad ORDER BY fecha_caducidad ASC LIMIT 1;
	
	IF v_id_inventario IS NOT NULL THEN
	UPDATE tbl_inventario
	SET stock_actual = stock_actual - p_cantidad
	WHERE id_inventario = v_id_inventario;
	
	INSERT INTO tbl_movimientos_inventario (fkid_inventario,tipo_movimiento, cantidad, motivo,fkid_usuario)
	VALUES (v_id_inventario, 'Salida', p_cantidad, p_motivo, p_fkid_usuario);
	
	ELSE
	SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Stock insuficiente';
	
	END IF;
	
END$$
DELIMITER ;

--Para mostrar el inventario en el datagrid 
CREATE OR REPLACE VIEW v_mostrar_inventario AS 
SELECT i.id_inventario, m.id_medicamento, m.nombre, m.tipo, m.presentacion, i.lote,i.fecha_caducidad, i.stock_actual, i.ubicacion 
FROM tbl_medicamentos m INNER JOIN tbl_inventario i ON m.id_medicamento = i.fkid_medicamento;

--Mostrar movimientos de inventario 
CREATE OR REPLACE VIEW v_mostrar_movimientos AS
SELECT 
    mov.id_movimiento,
    med.nombre AS 'Medicamento',
    inv.lote AS 'Lote',
    mov.tipo_movimiento AS 'Acción',
    mov.cantidad AS 'Cantidad',
    mov.motivo AS 'Concepto',
    mov.fecha AS 'Fecha',
    IFNULL(u.username, 'Sistema/Pendiente') AS 'Realizado por'
FROM tbl_movimientos_inventario mov
INNER JOIN tbl_inventario inv ON mov.fkid_inventario = inv.id_inventario
INNER JOIN tbl_medicamentos med ON inv.fkid_medicamento = med.id_medicamento
LEFT JOIN tbl_usuarios u ON mov.fkid_usuario = u.id_usuario;


CREATE OR REPLACE VIEW v_inventario AS
SELECT 
    i.id_inventario, 
    m.id_medicamento, 
    m.nombre AS Nombre, 
    m.descripcion AS Descripción, 
    m.tipo AS Tipo, 
    m.presentacion AS Presentación, 
    m.concentracion AS Concentración, 
    m.requiere_receta AS RequiereReceta,
    i.stock_actual AS Stock,
    i.estatus
FROM tbl_inventario i
INNER JOIN tbl_medicamentos m ON i.fkid_medicamento = m.id_medicamento;

--VISTA PARA LA BITÁCORA --
CREATE OR REPLACE VIEW v_bitacora AS 
SELECT 
    b.fkid_usuario, 
    u.nombre_completo AS 'Usuario',
    b.accion AS 'Acción Realizada', 
    b.fecha AS 'Fecha y Hora'
FROM tbl_bitacora b 
INNER JOIN v_NombreUsuario u ON b.fkid_usuario = u.id_usuario 
ORDER BY b.fecha DESC;

SELECT * FROM v_bitacora;

-- Procedimiento para filtrar roles para la bitácora --
DELIMITER $$

DROP PROCEDURE IF EXISTS p_consultar_bitacora$$

CREATE PROCEDURE p_consultar_bitacora(
    IN p_id_usuario INT,
    IN p_rol VARCHAR(50)
)
BEGIN
    IF p_rol = 'Admin' OR p_rol = 'Administrador' THEN
        SELECT 
            b.id_bitacora, 
            u.nombre_completo AS Usuario, 
            b.accion AS 'Acción Realizada', 
            b.fecha AS 'Fecha y Hora'
        FROM tbl_bitacora b
        INNER JOIN v_NombreUsuario u ON b.fkid_usuario = u.id_usuario
        WHERE DATE(b.fecha) = CURDATE() 
        ORDER BY b.fecha DESC;
    ELSE
        SELECT 
            b.id_bitacora, 
            u.nombre_completo AS Usuario, 
            b.accion AS 'Acción Realizada', 
            b.fecha AS 'Fecha y Hora'
        FROM tbl_bitacora b
        INNER JOIN v_NombreUsuario u ON b.fkid_usuario = u.id_usuario
        WHERE b.fkid_usuario = p_id_usuario 
          AND DATE(b.fecha) = CURDATE()
        ORDER BY b.fecha DESC;
    END IF;
END$$

DELIMITER ;


--MODIFIQUÉ LA VISTA DE VALERIA V_NombreUsuario 
CREATE OR REPLACE VIEW v_NombreUsuario AS
SELECT 
    u.id_usuario, 
    u.username,
    CONCAT(p.nombre, ' ', p.apellido) AS nombre_completo,
    r.nombre_rol AS rol 
FROM tbl_usuarios u
INNER JOIN tbl_personal p ON u.fkid_personal = p.id_personal
INNER JOIN tbl_roles r ON p.fkid_rol = r.id_rol;

-- Para mostrar los movimientos de inventario en el datagrid
CREATE OR REPLACE VIEW v_mostrar_movimientos AS
SELECT 
    m.id_movimiento,
    i.id_inventario, 
    med.nombre AS 'Medicamento',
    i.lote AS 'Lote',
    m.tipo_movimiento AS 'Acción',
    m.cantidad AS 'Cantidad',
    m.motivo AS 'Motivo',
    m.fecha AS 'Fecha'
FROM tbl_movimientos_inventario m
INNER JOIN tbl_inventario i ON m.fkid_inventario = i.id_inventario
INNER JOIN tbl_medicamentos med ON i.fkid_medicamento = med.id_medicamento;

--Eliminar un medicamento (solo elimina el registro del medicamento, no el inventario ni los movimientos históricos)
DELIMITER $$

DROP PROCEDURE IF EXISTS p_eliminar_o_ajustar_stock$$

CREATE PROCEDURE p_eliminar_o_ajustar_stock(
    IN p_id_inventario INT,
    IN p_cantidad INT,
    IN p_tipo_mov ENUM('Entrada','Salida','Ajuste'),
    IN p_motivo TEXT,
    IN p_id_usuario INT
)
BEGIN
    IF p_motivo LIKE '%Eliminación%' THEN
        UPDATE tbl_inventario 
        SET estatus = 'Agotado', 
            stock_actual = 0 
        WHERE id_inventario = p_id_inventario;
    ELSE
        IF p_tipo_mov = 'Entrada' THEN
            UPDATE tbl_inventario 
            SET stock_actual = stock_actual + p_cantidad,
                estatus = 'Activo' 
            WHERE id_inventario = p_id_inventario;
        ELSE
            UPDATE tbl_inventario 
            SET stock_actual = stock_actual - p_cantidad 
            WHERE id_inventario = p_id_inventario;
        END IF;
    END IF;
    INSERT INTO tbl_movimientos_inventario (
        fkid_inventario, 
        tipo_movimiento, 
        cantidad, 
        motivo, 
        fkid_usuario
    )
    VALUES (
        p_id_inventario, 
        p_tipo_mov, 
        p_cantidad, 
        p_motivo, 
        p_id_usuario
    );
    
    UPDATE tbl_inventario 
    SET estatus = 'Agotado' 
    WHERE id_inventario = p_id_inventario AND stock_actual <= 0;

END$$

DELIMITER ;
