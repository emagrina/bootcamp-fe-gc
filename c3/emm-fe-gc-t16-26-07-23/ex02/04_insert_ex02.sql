USE ex02;

-- INSERTS

INSERT INTO piezas (nombre) VALUES
('Tornillo'),
('Tuerca'),
('Resorte'),
('Perno'),
('Arandela'),
('Engranaje'),
('Válvula'),
('Sensor'),
('Cable'),
('Bisagra');

INSERT INTO proveedores (id, nombre) VALUES
('P001', 'Proveedor A'),
('P002', 'Proveedor B'),
('P003', 'Proveedor C'),
('P004', 'Proveedor D'),
('P005', 'Proveedor E'),
('P006', 'Proveedor F'),
('P007', 'Proveedor G'),
('P008', 'Proveedor H'),
('P009', 'Proveedor I'),
('P010', 'Proveedor J');

INSERT INTO suministra (codigo_pieza, id_proveedor, precio) VALUES
(1, 'P001', 50),
(2, 'P002', 40),
(3, 'P003', 60),
(4, 'P004', 70),
(5, 'P005', 55),
(1, 'P006', 65),
(2, 'P007', 45),
(6, 'P008', 100),
(7, 'P009', 13),
(8, 'P010', 55);

-- UPDATES

UPDATE piezas SET nombre = 'Tornillo modificado' WHERE codigo = 1;
UPDATE piezas SET nombre = 'Tuerca modificada' WHERE codigo = 2;
UPDATE piezas SET nombre = 'Resorte modificado' WHERE codigo = 3;
UPDATE piezas SET nombre = 'Perno modificado' WHERE codigo = 4;
UPDATE piezas SET nombre = 'Arandela modificada' WHERE codigo = 5;
UPDATE piezas SET nombre = 'Engranaje modificado' WHERE codigo = 6;
UPDATE piezas SET nombre = 'Válvula modificada' WHERE codigo = 7;
UPDATE piezas SET nombre = 'Sensor modificado' WHERE codigo = 8;
UPDATE piezas SET nombre = 'Cable modificado' WHERE codigo = 9;
UPDATE piezas SET nombre = 'Bisagra modificada' WHERE codigo = 10;

UPDATE proveedores SET nombre = 'Proveedor A S.A. de C.V.' WHERE id = 'P001';
UPDATE proveedores SET nombre = 'Distribuciones Industriales S.L.' WHERE id = 'P002';
UPDATE proveedores SET nombre = 'Suministros Electrónicos S.A.' WHERE id = 'P003';
UPDATE proveedores SET nombre = 'Proveedor Express Inc.' WHERE id = 'P004';
UPDATE proveedores SET nombre = 'Comercializadora de Herramientas S.A.' WHERE id = 'P005';
UPDATE proveedores SET nombre = 'Manufacturas y Componentes Ltda.' WHERE id = 'P006';
UPDATE proveedores SET nombre = 'Importadora de Materiales S.A.C.' WHERE id = 'P007';
UPDATE proveedores SET nombre = 'Suministros Médicos y Equipos S.A.' WHERE id = 'P008';
UPDATE proveedores SET nombre = 'Proveedor XYZ Ltd.' WHERE id = 'P009';
UPDATE proveedores SET nombre = 'Distribuidora de Insumos Industriales Ltda.' WHERE id = 'P010';


-- DELETES

DELETE FROM piezas WHERE codigo = 1;
DELETE FROM piezas WHERE codigo = 2;
DELETE FROM piezas WHERE codigo = 3;
DELETE FROM piezas WHERE codigo = 4;
DELETE FROM piezas WHERE codigo = 5;