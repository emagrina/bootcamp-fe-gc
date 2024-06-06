USE ex04;

-- INSERTS

INSERT INTO productos (nombre, precio) VALUES
('Producto 1', 100),
('Producto 2', 200),
('Producto 3', 150),
('Producto 4', 300),
('Producto 5', 250),
('Producto 6', 180),
('Producto 7', 220),
('Producto 8', 120),
('Producto 9', 270),
('Producto 10', 190);

INSERT INTO maquinas_registradas (piso) VALUES
(1),
(2),
(1),
(3),
(2),
(1),
(3),
(1),
(2),
(1);

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
(3, 3, 3),
(4, 4, 4),
(5, 5, 5),
(6, 6, 6),
(7, 7, 7),
(8, 8, 8),
(9, 9, 9),
(10, 10, 10);

-- UPDATES

UPDATE productos SET nombre = 'Producto 11', precio = 110 WHERE codigo = 1;
UPDATE productos SET nombre = 'Producto 12', precio = 220 WHERE codigo = 2;
UPDATE productos SET nombre = 'Producto 13', precio = 160 WHERE codigo = 3;
UPDATE productos SET nombre = 'Producto 14', precio = 310 WHERE codigo = 4;
UPDATE productos SET nombre = 'Producto 15', precio = 260 WHERE codigo = 5;
UPDATE productos SET nombre = 'Producto 16', precio = 190 WHERE codigo = 6;
UPDATE productos SET nombre = 'Producto 17', precio = 230 WHERE codigo = 7;
UPDATE productos SET nombre = 'Producto 18', precio = 130 WHERE codigo = 8;
UPDATE productos SET nombre = 'Producto 19', precio = 280 WHERE codigo = 9;
UPDATE productos SET nombre = 'Producto 20', precio = 200 WHERE codigo = 10;

UPDATE maquinas_registradas SET piso = 2 WHERE codigo = 1;
UPDATE maquinas_registradas SET piso = 1 WHERE codigo = 2;
UPDATE maquinas_registradas SET piso = 3 WHERE codigo = 3;
UPDATE maquinas_registradas SET piso = 2 WHERE codigo = 4;
UPDATE maquinas_registradas SET piso = 1 WHERE codigo = 5;
UPDATE maquinas_registradas SET piso = 3 WHERE codigo = 6;
UPDATE maquinas_registradas SET piso = 1 WHERE codigo = 7;
UPDATE maquinas_registradas SET piso = 2 WHERE codigo = 8;
UPDATE maquinas_registradas SET piso = 3 WHERE codigo = 9;
UPDATE maquinas_registradas SET piso = 1 WHERE codigo = 10;

UPDATE cajeros SET nom_apels = 'Cajero 11' WHERE codigo = 1;
UPDATE cajeros SET nom_apels = 'Cajero 12' WHERE codigo = 2;
UPDATE cajeros SET nom_apels = 'Cajero 13' WHERE codigo = 3;
UPDATE cajeros SET nom_apels = 'Cajero 14' WHERE codigo = 4;
UPDATE cajeros SET nom_apels = 'Cajero 15' WHERE codigo = 5;
UPDATE cajeros SET nom_apels = 'Cajero 16' WHERE codigo = 6;
UPDATE cajeros SET nom_apels = 'Cajero 17' WHERE codigo = 7;
UPDATE cajeros SET nom_apels = 'Cajero 18' WHERE codigo = 8;
UPDATE cajeros SET nom_apels = 'Cajero 19' WHERE codigo = 9;
UPDATE cajeros SET nom_apels = 'Cajero 20' WHERE codigo = 10;

-- DELETES

DELETE FROM productos WHERE codigo = 1;
DELETE FROM productos WHERE codigo = 2;
DELETE FROM productos WHERE codigo = 3;
DELETE FROM productos WHERE codigo = 4;
DELETE FROM productos WHERE codigo = 5;
DELETE FROM productos WHERE codigo = 6;
DELETE FROM productos WHERE codigo = 7;
DELETE FROM productos WHERE codigo = 8;
DELETE FROM productos WHERE codigo = 9;
DELETE FROM productos WHERE codigo = 10;