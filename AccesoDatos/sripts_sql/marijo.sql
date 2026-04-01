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
