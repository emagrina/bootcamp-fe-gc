INSERT INTO piezas (nombre) VALUES
('Pieza 1'),
('Pieza 2'),
('Pieza 3'),
('Pieza 4'),
('Pieza 5'),
('Pieza 6'),
('Pieza 7'),
('Pieza 8'),
('Pieza 9'),
('Pieza 10');

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
(1, 'P001', 100),
(2, 'P002', 120),
(3, 'P003', 80),
(4, 'P004', 150),
(5, 'P005', 90),
(6, 'P006', 200),
(7, 'P007', 110),
(8, 'P008', 130),
(9, 'P009', 70),
(10, 'P010', 180);
