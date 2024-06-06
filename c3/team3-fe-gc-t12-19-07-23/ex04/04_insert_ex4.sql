INSERT INTO guerra (id, nombre, ano_inicio, ano_fin)
VALUES
(1, 'Guerra de Vietnam', 1955, 1975),
(2, 'Guerra del Golfo', 1990, 1991),
(3, 'Guerra de Corea', 1950, 1953),
(4, 'Guerra de Irak', 2003, 2011),
(5, 'Guerra de Siria', 2011, NULL),
(6, 'Guerra de los Cien Años', 1337, 1453),
(7, 'Guerra de Independencia de México', 1810, 1821),
(8, 'Guerra de los Seis Días', 1967, 1967),
(9, 'Guerra de las Malvinas', 1982, 1982),
(10, 'Guerra de Afganistán', 2001, NULL);

INSERT INTO pais (id, nombre, ano_independencia_inicio, ano_independencia_fin)
VALUES
(1, 'Vietnam', 1945, NULL),
(2, 'Irak', 1932, NULL),
(3, 'Corea del Norte', 1948, NULL),
(4, 'Siria', 1946, NULL),
(5, 'Argentina', 1816, NULL),
(6, 'México', 1821, NULL),
(7, 'Francia', NULL, NULL),
(8, 'Reino Unido', NULL, NULL),
(9, 'Israel', NULL, NULL),
(10, 'Palestina', NULL, NULL);

INSERT INTO bando (id, nombre)
VALUES
(1, 'Aliados'),
(2, 'Eje'),
(3, 'Coalición Internacional'),
(4, 'Rebeldes'),
(5, 'Gobierno');

INSERT INTO participacion (id, id_guerra, id_pais, ano_entrada, ano_salida, ganador)
VALUES
(1, 1, 1, 1955, 1973, FALSE),
(2, 1, 3, 1950, 1953, TRUE),
(3, 1, 5, 1965, 1973, FALSE),
(4, 2, 1, 1990, 1991, FALSE),
(5, 2, 8, 1991, 1991, TRUE),
(6, 3, 3, 1950, 1953, FALSE),
(7, 3, 9, 1950, 1953, FALSE),
(8, 4, 2, 2003, 2011, FALSE),
(9, 4, 4, 2003, 2011, FALSE),
(10, 5, 4, 2011, NULL, NULL);

INSERT INTO afiliacion (id, id_bando, id_pais)
VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 3, 1),
(5, 3, 2),
(6, 4, 3),
(7, 4, 4),
(8, 5, 5),
(9, 5, 6),
(10, 1, 7);
