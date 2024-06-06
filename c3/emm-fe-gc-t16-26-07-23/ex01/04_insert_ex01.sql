USE ex01;

-- INSERTS

INSERT INTO despachos (numero, capacidad) VALUES
(101, 5),
(102, 3),
(103, 6),
(104, 4),
(105, 7),
(106, 5),
(107, 8),
(108, 6),
(109, 4),
(110, 5);

INSERT INTO directores (dni, nom_apels, dni_jefe, despacho) VALUES
('11111111', 'Director 1', NULL, 101),
('22222222', 'Director 2', '11111111', 102),
('33333333', 'Director 3', '11111111', 103),
('44444444', 'Director 4', '22222222', 104),
('55555555', 'Director 5', '22222222', 105),
('66666666', 'Director 6', '33333333', 106),
('77777777', 'Director 7', '33333333', 107),
('88888888', 'Director 8', '44444444', 108),
('99999999', 'Director 9', '44444444', 109),
('12345678', 'Director 10', '55555555', 110);

-- UPDATES

UPDATE despachos SET capacidad = 6 WHERE numero = 101;
UPDATE despachos SET capacidad = 4 WHERE numero = 102;
UPDATE despachos SET capacidad = 7 WHERE numero = 103;
UPDATE despachos SET capacidad = 5 WHERE numero = 104;
UPDATE despachos SET capacidad = 8 WHERE numero = 105;
UPDATE despachos SET capacidad = 5 WHERE numero = 106;
UPDATE despachos SET capacidad = 9 WHERE numero = 107;
UPDATE despachos SET capacidad = 7 WHERE numero = 108;
UPDATE despachos SET capacidad = 5 WHERE numero = 109;
UPDATE despachos SET capacidad = 6 WHERE numero = 110;

UPDATE directores SET nom_apels = 'Director 11' WHERE dni = '11111111';
UPDATE directores SET nom_apels = 'Director 12' WHERE dni = '22222222';
UPDATE directores SET nom_apels = 'Director 13' WHERE dni = '33333333';
UPDATE directores SET nom_apels = 'Director 14' WHERE dni = '44444444';
UPDATE directores SET nom_apels = 'Director 15' WHERE dni = '55555555';
UPDATE directores SET nom_apels = 'Director 16' WHERE dni = '66666666';
UPDATE directores SET nom_apels = 'Director 17' WHERE dni = '77777777';
UPDATE directores SET nom_apels = 'Director 18' WHERE dni = '88888888';
UPDATE directores SET nom_apels = 'Director 19' WHERE dni = '99999999';
UPDATE directores SET nom_apels = 'Director 20' WHERE dni = '12345678';

-- DELETES

DELETE FROM directores WHERE dni = '12345678';
DELETE FROM directores WHERE dni = '99999999';
DELETE FROM directores WHERE dni = '88888888';
DELETE FROM directores WHERE dni = '77777777';
DELETE FROM directores WHERE dni = '66666666';
