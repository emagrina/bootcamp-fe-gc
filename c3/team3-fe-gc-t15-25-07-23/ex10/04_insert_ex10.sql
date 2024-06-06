INSERT INTO productos (nombre, precio) VALUES
('Producto 1', 100),
('Producto 2', 120),
('Producto 3', 80),
('Producto 4', 150),
('Producto 5', 90),
('Producto 6', 200),
('Producto 7', 110),
('Producto 8', 130),
('Producto 9', 70),
('Producto 10', 180);

INSERT INTO maquinas_registradas (piso) VALUES
(1),
(2),
(1),
(3),
(2),
(4),
(3),
(2),
(1),
(4);

INSERT INTO cajeros (nom_apels) VALUES
('Cajero 1'),
('Cajero 2'),
('Cajero 3'),
('Cajero 4'),
('Cajero 5'),
('Cajero 6'),
('Cajero 7'),
('Cajero 8'),
('Cajero 9'),
('Cajero 10');

INSERT INTO ventas (cajero, maquina, producto) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 1, 3),
(4, 3, 4),
(5, 2, 5),
(6, 4, 6),
(7, 3, 7),
(8, 2, 8),
(9, 1, 9),
(10, 4, 10);
