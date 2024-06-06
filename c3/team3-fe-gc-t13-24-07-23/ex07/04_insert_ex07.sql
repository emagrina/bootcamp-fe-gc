-- Insertar datos en la tabla arrendatarios
INSERT INTO arrendatarios VALUES ('A12345678', 'Empresa ABC', 'Juan Pérez', 'Calle Falsa 123', 28001, 'Madrid', 'Madrid', 912345678, 612345678, 912345679, 'Alquiler de naves industriales');

-- Insertar datos en la tabla naves
INSERT INTO naves VALUES (1, 'Polígono Industrial La Vega', 'Calle de la Industria', 1, 'Madrid', 28002, 'Madrid', 912345670, 'Nave de 1000m2 con oficinas', 'foto.jpg', 'datos_escritura.pdf', TRUE, 100.50);

-- Insertar datos en la tabla recibos
INSERT INTO recibos VALUES (1, 1000.00, 210.00, TRUE, '2023-08-01');

-- Insertar datos en la tabla arrendatarios_naves
INSERT INTO arrendatarios_naves VALUES ('A12345678', 1, 1234567890, 5, '2023-01-01', '2023-12-31', 1000.00);

-- Insertar datos en la tabla naves_recibos
INSERT INTO naves_recibos VALUES (1, 1);
