USE ex09;

INSERT INTO cientificos (dni, nom_apels) VALUES
('12345678', 'Juan Pérez'),
('23456789', 'María López'),
('34567890', 'Pedro Gómez'),
('45678901', 'Ana Martínez'),
('56789012', 'Luis Rodríguez');

INSERT INTO proyectos (id, nombre, horas) VALUES
('P001', 'Proyecto A', 100),
('P002', 'Proyecto B', 80),
('P003', 'Proyecto C', 120),
('P004', 'Proyecto D', 150),
('P005', 'Proyecto E', 200);

INSERT INTO asignado_a (cientifico, proyecto) VALUES
('12345678', 'P001'),
('12345678', 'P002'),
('23456789', 'P002'),
('34567890', 'P001'),
('34567890', 'P003'),
('45678901', 'P005'),
('56789012', 'P003'),
('56789012', 'P004');
