-- Insertar datos en la tabla fondos
INSERT INTO fondos VALUES ('El Quijote', 'Miguel de Cervantes', 10);
INSERT INTO fondos VALUES ('1984', 'George Orwell', 8);
INSERT INTO fondos VALUES ('Don Juan Tenorio', 'Jose Zorrilla', 6);

-- Insertar datos en la tabla libros
INSERT INTO libros VALUES (1, TRUE, 'El Quijote', 'Miguel de Cervantes');
INSERT INTO libros VALUES (2, FALSE, '1984', 'George Orwell');
INSERT INTO libros VALUES (3, TRUE, 'Don Juan Tenorio', 'Jose Zorrilla');

-- Insertar datos en la tabla prestamos
INSERT INTO prestamos VALUES (1, '2023-08-01', 'préstamo_socio', 1);
INSERT INTO prestamos VALUES (2, '2023-08-02', 'préstamo_externo', 2);
INSERT INTO prestamos VALUES (3, '2023-08-03', 'préstamo_socio', 3);

-- Insertar datos en la tabla prestamos_s
INSERT INTO prestamos_s VALUES (1);
INSERT INTO prestamos_s VALUES (3);

-- Insertar datos en la tabla prestamos_e
INSERT INTO prestamos_e VALUES (2, '2023-08-10');

-- Insertar datos en la tabla socios
INSERT INTO socios VALUES (1, 'Juan', 'Perez', 123456789, '2024-08-01');
INSERT INTO socios VALUES (2, 'Ana', 'Gonzalez', 987654321, '2024-09-01');

-- Insertar datos en la tabla sanciones
INSERT INTO sanciones VALUES (10);
INSERT INTO sanciones VALUES (5);

-- Insertar datos en la tabla prestamos_socios
INSERT INTO prestamos_socios VALUES (1, 1);
INSERT INTO prestamos_socios VALUES (3, 2);

-- Insertar datos en la tabla socios_sanciones
INSERT INTO socios_sanciones VALUES (1, 5);
INSERT INTO socios_sanciones VALUES (2, 10);
