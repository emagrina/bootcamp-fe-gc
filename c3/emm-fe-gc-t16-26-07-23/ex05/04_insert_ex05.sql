USE ex05;

-- INSERTS

INSERT INTO facultades (codigo, nombre) VALUES
(1, 'Facultad de Ciencias'),
(2, 'Facultad de Ingeniería'),
(3, 'Facultad de Medicina'),
(4, 'Facultad de Artes'),
(5, 'Facultad de Derecho'),
(6, 'Facultad de Economía'),
(7, 'Facultad de Psicología'),
(8, 'Facultad de Comunicación'),
(9, 'Facultad de Educación'),
(10, 'Facultad de Odontología');

INSERT INTO equipos (num_serie, nombre, facultat) VALUES
('E001', 'Equipo 1', 1),
('E002', 'Equipo 2', 2),
('E003', 'Equipo 3', 1),
('E004', 'Equipo 4', 3),
('E005', 'Equipo 5', 2),
('E006', 'Equipo 6', 1),
('E007', 'Equipo 7', 3),
('E008', 'Equipo 8', 1),
('E009', 'Equipo 9', 2),
('E010', 'Equipo 10', 1);

INSERT INTO investigadores (dni, nom_apels, facultat) VALUES
('12345678', 'Juan Pérez', 1),
('23456789', 'María López', 2),
('34567890', 'Pedro Gómez', 1),
('45678901', 'Ana Martínez', 3),
('56789012', 'Carlos Ramírez', 2),
('67890123', 'Laura Hernández', 1),
('78901234', 'Javier Fernández', 3),
('89012345', 'Sofía Rodríguez', 1),
('90123456', 'Miguel Sánchez', 2),
('01234567', 'Lucía Gutiérrez', 1);

INSERT INTO reservas (dni, num_serie, comienzo, fin) VALUES
('12345678', 'E001', '2023-07-31 10:00:00', '2023-07-31 12:00:00'),
('23456789', 'E002', '2023-08-01 14:00:00', '2023-08-01 16:00:00'),
('34567890', 'E001', '2023-08-02 09:00:00', '2023-08-02 11:00:00'),
('45678901', 'E004', '2023-08-03 13:00:00', '2023-08-03 15:00:00'),
('56789012', 'E003', '2023-08-04 11:00:00', '2023-08-04 13:00:00'),
('67890123', 'E005', '2023-08-05 16:00:00', '2023-08-05 18:00:00'),
('78901234', 'E001', '2023-08-06 12:00:00', '2023-08-06 14:00:00'),
('89012345', 'E007', '2023-08-07 15:00:00', '2023-08-07 17:00:00'),
('90123456', 'E009', '2023-08-08 10:00:00', '2023-08-08 12:00:00'),
('01234567', 'E002', '2023-08-09 13:00:00', '2023-08-09 15:00:00');

-- UPDATES

UPDATE facultades SET nombre = 'Facultad de Matemáticas' WHERE codigo = 1;
UPDATE facultades SET nombre = 'Facultad de Informática' WHERE codigo = 2;
UPDATE facultades SET nombre = 'Facultad de Biología' WHERE codigo = 3;
UPDATE facultades SET nombre = 'Facultad de Música' WHERE codigo = 4;
UPDATE facultades SET nombre = 'Facultad de Derecho' WHERE codigo = 5;
UPDATE facultades SET nombre = 'Facultad de Economía' WHERE codigo = 6;
UPDATE facultades SET nombre = 'Facultad de Psicología' WHERE codigo = 7;
UPDATE facultades SET nombre = 'Facultad de Comunicación' WHERE codigo = 8;
UPDATE facultades SET nombre = 'Facultad de Educación' WHERE codigo = 9;
UPDATE facultades SET nombre = 'Facultad de Odontología' WHERE codigo = 10;

UPDATE equipos SET nombre = 'Laboratorio de Química', facultat = 1 WHERE num_serie = 'E001';
UPDATE equipos SET nombre = 'Laboratorio de Informática', facultat = 2 WHERE num_serie = 'E002';
UPDATE equipos SET nombre = 'Laboratorio de Física', facultat = 1 WHERE num_serie = 'E003';
UPDATE equipos SET nombre = 'Sala de Cirugía', facultat = 3 WHERE num_serie = 'E004';
UPDATE equipos SET nombre = 'Laboratorio de Electrónica', facultat = 2 WHERE num_serie = 'E005';
UPDATE equipos SET nombre = 'Laboratorio de Biología', facultat = 1 WHERE num_serie = 'E006';
UPDATE equipos SET nombre = 'Sala de Psicología', facultat = 3 WHERE num_serie = 'E007';
UPDATE equipos SET nombre = 'Estudio de Comunicación', facultat = 1 WHERE num_serie = 'E008';
UPDATE equipos SET nombre = 'Laboratorio de Informática Avanzada', facultat = 2 WHERE num_serie = 'E009';
UPDATE equipos SET nombre = 'Laboratorio de Química Orgánica', facultat = 1 WHERE num_serie = 'E010';

UPDATE investigadores SET nom_apels = 'Laura Pérez', facultat = 1 WHERE dni = '12345678';
UPDATE investigadores SET nom_apels = 'Carlos López', facultat = 2 WHERE dni = '23456789';
UPDATE investigadores SET nom_apels = 'Sofía Gómez', facultat = 1 WHERE dni = '34567890';
UPDATE investigadores SET nom_apels = 'Javier Martínez', facultat = 3 WHERE dni = '45678901';
UPDATE investigadores SET nom_apels = 'Ana Ramírez', facultat = 2 WHERE dni = '56789012';
UPDATE investigadores SET nom_apels = 'Miguel Hernández', facultat = 1 WHERE dni = '67890123';
UPDATE investigadores SET nom_apels = 'Lucía Fernández', facultat = 3 WHERE dni = '78901234';
UPDATE investigadores SET nom_apels = 'Pedro Rodríguez', facultat = 1 WHERE dni = '89012345';
UPDATE investigadores SET nom_apels = 'María Sánchez', facultat = 2 WHERE dni = '90123456';
UPDATE investigadores SET nom_apels = 'Juan Gutiérrez', facultat = 1 WHERE dni = '01234567';

-- DELETES

DELETE FROM investigadores WHERE dni = '12345678';
DELETE FROM investigadores WHERE dni = '23456789';
DELETE FROM investigadores WHERE dni = '34567890';
DELETE FROM investigadores WHERE dni = '45678901';
DELETE FROM investigadores WHERE dni = '56789012';