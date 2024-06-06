USE ex07;

INSERT INTO despachos (numero, capacidad) VALUES
(1, 4),
(2, 3),
(3, 5),
(4, 2),
(5, 6);

INSERT INTO directores (dni, nom_apels, dni_jefe, despacho) VALUES
('11111111', 'Juan Pérez', NULL, 1),
('22222222', 'María López', '11111111', 2),
('33333333', 'Pedro Gómez', '11111111', 3),
('44444444', 'Ana Martínez', '11111111', 4),
('55555555', 'Luis Rodríguez', '11111111', 5);
