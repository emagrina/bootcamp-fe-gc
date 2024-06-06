-- Tabla elementos
INSERT INTO elementos VALUES ('Hidrogeno', 1.00784, 'H', 1);
INSERT INTO elementos VALUES ('Oxigeno', 15.999, 'O', 8);
INSERT INTO elementos VALUES ('Carbono', 12.011, 'C', 6);

-- Tabla compuestos
INSERT INTO compuestos VALUES ('Agua', 'Liquido');
INSERT INTO compuestos VALUES ('Dioxido de carbono', 'Gaseoso');
INSERT INTO compuestos VALUES ('Diamante', 'Solido');

-- Tabla elementos_compuestos
INSERT INTO elementos_compuestos VALUES ('Agua', 'Hidrogeno', 2);
INSERT INTO elementos_compuestos VALUES ('Agua', 'Oxigeno', 1);
INSERT INTO elementos_compuestos VALUES ('Dioxido de carbono', 'Carbono', 1);
INSERT INTO elementos_compuestos VALUES ('Dioxido de carbono', 'Oxigeno', 2);
INSERT INTO elementos_compuestos VALUES ('Diamante', 'Carbono', 1);

-- Tabla gaseosos
INSERT INTO gaseosos VALUES ('Dioxido de carbono', 0.001977, -78);

-- Tabla liquidos
INSERT INTO liquidos VALUES ('Agua', 1.0, 100);

-- Tabla solidos
INSERT INTO solidos VALUES ('Diamante', 'Incoloro', 'Inodoro', 10);

