INSERT INTO localidades (id, nombre, poblacion)
VALUES
(101, 'Sevilla capital', 689434),
(201, 'Badalona', 1620809),
(301, 'Alcorcón', 6723694),
(401, 'Barcheta', 5003769),
(501, 'Santiago de Compostela', 95564),
(601, 'Valladolid', 298412),
(701, 'Bilbao', 345821),
(801, 'Las Palmas de Gran Canaria', 383308),
(901, 'Alcabón', 83545),
(1001, 'Abanto', 674997);

INSERT INTO comunidades_autonomas (id, nombre, poblacion, superficie, comunidades_autonomas_id_capital)
VALUES
(1, 'Andalucía', 8446561, 87599.78, 101),
(2, 'Cataluña', 7611107, 32114.09, 201),
(3, 'Madrid', 6723694, 8028.00, 301),
(4, 'Valencia', 5003769, 23255.97, 401),
(5, 'Galicia', 2699499, 29574.18, 501),
(6, 'Castilla y León', 2399543, 94222.36, 601),
(7, 'País Vasco', 2207776, 7254.94, 701),
(8, 'Canarias', 2227189, 7447.16, 801),
(9, 'Castilla-La Mancha', 2032863, 79566.92, 901),
(10, 'Aragón', 1320794, 47720.57, 1001);

INSERT INTO provincias (codigo_postal, nombre, poblacion, superficie, comunidad_autonoma_id, comunidades_autonomas_id_capital)
VALUES
(101, 'Sevilla', 1942389, 14036.05, 1, 101), 
(102, 'Málaga', 1698180, 7306.39, 1, 101), 
(103, 'Córdoba', 799982, 13771.96, 1, 101),
(104, 'Granada', 914678, 12646.38, 1, 101),
(105, 'Madrid', 631830, 13428.31, 3, 101),
(106, 'Huelva', 522537, 10127.14, 1, 101),
(107, 'Cádiz', 1240155, 7440.61, 1, 101),
(201, 'Barcelona', 5653402, 7720.21, 2, 201),
(202, 'Girona', 780963, 5901.89, 2, 201),
(203, 'Tarragona', 795196, 6307.92, 2, 201);

INSERT INTO localidades_provincias (localidades_id, provincia_codigo_postal)
VALUES
(101, 101),
(201, 201),
(301, 105),
(401, 103),
(501, 105),
(601, 106),
(701, 201),
(801, 202),
(901, 203),
(1001, 101);

INSERT INTO provincias_comunidades_autonomas (provincia_codigo_postal, provincias_comunidades_autonomas_id)
VALUES
(101, 1), 
(102, 2), 
(103, 3),
(104, 4),
(105, 5),
(106, 6),
(107, 7),
(201, 8),
(202, 9),
(203, 10);
