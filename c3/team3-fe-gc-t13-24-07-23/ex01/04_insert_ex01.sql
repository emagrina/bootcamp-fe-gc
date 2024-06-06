-- Insertar datos en la tabla cargos
INSERT INTO cargos VALUES (1, 'Administrador', 'Gestionar propiedades');
INSERT INTO cargos VALUES (2, 'Mantenimiento', 'Reparaciones generales');

-- Insertar datos en la tabla pisos
INSERT INTO pisos VALUES ('101', '12345678A', 'Juan', 'Perez', 'Calle Falsa 123', 28001, 'Madrid');
INSERT INTO pisos VALUES ('102', '23456789B', 'Ana', 'Gomez', 'Avenida Siempre Viva 456', 28002, 'Madrid');

-- Insertar datos en la tabla anotaciones
INSERT INTO anotaciones VALUES (1, '2023-08-01', 1000);
INSERT INTO anotaciones VALUES (2, '2023-08-01', 500);

-- Insertar datos en la tabla ingreso_recibos
INSERT INTO ingreso_recibos VALUES (1, '2023-08-01', TRUE, '101');
INSERT INTO ingreso_recibos VALUES (2, '2023-08-01', FALSE, '102');

-- Insertar datos en la tabla detalle_recibos
INSERT INTO detalle_recibos VALUES (1, 'Renta', 500);
INSERT INTO detalle_recibos VALUES (2, 'Electricidad', 100);

-- Insertar datos en la tabla ingresos_extra
INSERT INTO ingresos_extra VALUES (1, 'Pago deuda anterior');

-- Insertar datos en la tabla gastos_fijos
INSERT INTO gastos_fijos VALUES (2, '2023-08-01', '2023-08-31', 50);

-- Insertar datos en la tabla tipo_gastos_fijos
INSERT INTO tipo_gastos_fijos VALUES (1, 'Electricidad', 'Gasto en electricidad');
INSERT INTO tipo_gastos_fijos VALUES (2, 'Agua', 'Gasto en agua');

-- Insertar datos en la tabla gastos_variables
INSERT INTO gastos_variables VALUES (1, '2023-08-01', 'Reparación ascensor', 1234);

-- Insertar datos en la tabla piso_cargo
INSERT INTO piso_cargo VALUES ('101', 1);
INSERT INTO piso_cargo VALUES ('102', 2);

-- Insertar datos en la tabla piso_detalle_recibo
INSERT INTO piso_detalle_recibo VALUES ('101', 1);
INSERT INTO piso_detalle_recibo VALUES ('102', 2);

-- Insertar datos en la tabla anotacion_tipo_gasto_fijo
INSERT INTO anotacion_tipo_gasto_fijo VALUES (1, 1);
INSERT INTO anotacion_tipo_gasto_fijo VALUES (2, 2);
