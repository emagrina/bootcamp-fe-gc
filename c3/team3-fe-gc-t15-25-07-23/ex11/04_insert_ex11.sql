USE ex11;

INSERT INTO facultades (codigo, nombre) VALUES
(1, 'Facultad de Ciencias'),
(2, 'Facultad de Ingeniería'),
(3, 'Facultad de Medicina');

INSERT INTO equipos (num_serie, nombre, facultat) VALUES
('E001', 'Equipo 1', 1),
('E002', 'Equipo 2', 2),
('E003', 'Equipo 3', 1),
('E004', 'Equipo 4', 3);

INSERT INTO investigadores (dni, nom_apels, facultat) VALUES
('12345678', 'Juan Pérez', 1),
('23456789', 'María López', 2),
('34567890', 'Pedro Gómez', 1),
('45678901', 'Ana Martínez', 3);

INSERT INTO reservas (dni, num_serie, comienzo, fin) VALUES
('12345678', 'E001', '2023-07-31 10:00:00', '2023-07-31 12:00:00'),
('23456789', 'E002', '2023-08-01 14:00:00', '2023-08-01 16:00:00'),
('34567890', 'E001', '2023-08-02 09:00:00', '2023-08-02 11:00:00'),
('45678901', 'E004', '2023-08-03 13:00:00', '2023-08-03 15:00:00');