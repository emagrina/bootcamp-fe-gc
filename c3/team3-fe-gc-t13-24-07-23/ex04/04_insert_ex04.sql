-- Insertar datos en la tabla parques_bomberos
INSERT INTO parques_bomberos VALUES (1, 'Parque Central', 'Calle Primera, 1', 123456789, 'Principal');
INSERT INTO parques_bomberos VALUES (2, 'Parque Norte', 'Avenida Norte, 45', 987654321, 'Secundario');

-- Insertar datos en la tabla coches
INSERT INTO coches VALUES (1, 1, 'Mercedes-Benz', 'Atego', 'ABC1234', '2020-01-01', '2023-01-01');
INSERT INTO coches VALUES (2, 1, 'Scania', 'P320', 'DEF5678', '2021-01-01', '2023-06-01');

-- Insertar datos en la tabla peticiones_servicios
INSERT INTO peticiones_servicios VALUES (1, 'Apagar fuego', 'Alta');
INSERT INTO peticiones_servicios VALUES (2, 'Rescate', 'Media');

-- Insertar datos en la tabla parques_bomberos_peticiones_servicios
INSERT INTO parques_bomberos_peticiones_servicios VALUES (1, 1, '2023-08-01', '12:00:00');
INSERT INTO parques_bomberos_peticiones_servicios VALUES (2, 2, '2023-08-02', '13:00:00');

-- Insertar datos en la tabla equipos
INSERT INTO equipos VALUES (1, 'Equipo Rojo');
INSERT INTO equipos VALUES (2, 'Equipo Azul');

-- Insertar datos en la tabla peticiones_servicios_equipos
INSERT INTO peticiones_servicios_equipos VALUES (1, 1);
INSERT INTO peticiones_servicios_equipos VALUES (2, 2);

-- Insertar datos en la tabla bomberos
INSERT INTO bomberos VALUES (1, 'Juan', 'Perez', '1980-01-01', '12345678A', 'Calle Primera, 1', 123456789);
INSERT INTO bomberos VALUES (2, 'Ana', 'Gonzalez', '1985-01-01', '98765432B', 'Avenida Norte, 45', 987654321);

-- Insertar datos en la tabla turnos
INSERT INTO turnos VALUES (1, 'Turno de día');
INSERT INTO turnos VALUES (2, 'Turno de noche');

-- Insertar datos en la tabla periodos
INSERT INTO periodos VALUES ('2023-08-01', '2023-08-07');
INSERT INTO periodos VALUES ('2023-08-08', '2023-08-14');

-- Insertar datos en la tabla bomberos_turnos_periodos
INSERT INTO bomberos_turnos_periodos VALUES (1, 1, '2023-08-01', '2023-08-07');
INSERT INTO bomberos_turnos_periodos VALUES (2, 2, '2023-08-08', '2023-08-14');

-- Insertar datos en la tabla bomberos_parques_bomberos
INSERT INTO bomberos_parques_bomberos VALUES (1, 1);
INSERT INTO bomberos_parques_bomberos VALUES (2, 2);

-- Insertar datos en la tabla bomberos_equipos
INSERT INTO bomberos_equipos VALUES (1, 1, 'Capitán');
INSERT INTO bomberos_equipos VALUES (2, 2, 'Teniente');
