INSERT INTO paises (nombre, extension, poblacion)
VALUES
('Argentina', 2780400, 45195777),
('Nepal', 147516, 29304998),
('Brasil', 8515767, 212559417),
('Egipto', 1001450, 102334404),
('Perú', 1285216, 32971846),
('Tanzania', 947303, 58005463),
('Estados Unidos', 9833517, 331002651),
('China', 9596960, 1439323776);


INSERT INTO accidentes_geograficos (id, nombre, posicion_horizontal, posicion_vertical, nombre_pais)
VALUES
(1, 'Montaña Aconcagua', -32.6536, -70.0113, 'Argentina'),
(2, 'Montaña Everest', 27.9881, 86.9253, 'Nepal'),
(3, 'Río Amazonas', -3.4653, -62.2159, 'Brasil'),
(4, 'Río Nilo', 30.8025, 31.0119, 'Egipto'),
(5, 'Lago Titicaca', -15.7748, -69.4069, 'Perú'),
(6, 'Lago Victoria', -1.3192, 32.2792, 'Tanzania'),
(7, 'Montaña Kilimanjaro', -3.0754, 37.3535, 'Tanzania'),
(8, 'Montaña Denali', 63.0694, -151.0074, 'Estados Unidos'),
(9, 'Río Yangtsé', 31.9722, 121.2213, 'China'),
(10, 'Río Misisipi', 29.7604, -95.3698, 'Estados Unidos');


INSERT INTO rios (id, longitud)
VALUES
(3, 7062),
(4, 6650),
(9, 6300),
(10, 6275);

INSERT INTO montanas (id, altura)
VALUES
(1, 6962),
(2, 8848),
(7, 5895),
(8, 6190);

INSERT INTO lagos (id, extension)
VALUES
(5, 8560),
(6, 68870);

INSERT INTO localidades (nombre, id_rio, nombre_pais)
VALUES
('Ciudad A', 3, 'Brasil'),
('Ciudad B', 4, 'Egipto'),
('Ciudad C', 9, 'China'),
('Ciudad D', 9, 'China'),
('Ciudad E', 3, 'Brasil'),
('Ciudad F', 4, 'Egipto'),
('Ciudad H', 10, 'Estados Unidos');