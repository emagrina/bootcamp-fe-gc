INSERT INTO pieza (id, descripcion, precio)
VALUES
(1, 'Tornillo', 0.5),
(2, 'Tuerca', 0.3),
(3, 'Arandela', 0.2),
(4, 'Resorte', 1.2),
(5, 'Clavo', 0.8),
(6, 'Tornillo de banco', 15.5),
(7, 'Cable', 2.3),
(8, 'Herramienta', 12.0),
(9, 'Engrane', 3.7),
(10, 'Cinta adhesiva', 1.0);

INSERT INTO almacen (id, descripcion, direccion)
VALUES
(1, 'Almacén Central', 'Calle Principal, 123'),
(2, 'Almacén Norte', 'Avenida del Almacén, 45'),
(3, 'Almacén Sur', 'Calle del Almacén, 78'),
(4, 'Almacén Este', 'Calle del Almacén, 54'),
(5, 'Almacén Oeste', 'Avenida del Almacén, 99'),
(6, 'Almacén 1', 'Calle Almacén, 12'),
(7, 'Almacén 2', 'Calle Almacén, 34'),
(8, 'Almacén 3', 'Avenida Almacén, 56'),
(9, 'Almacén 4', 'Avenida Almacén, 78'),
(10, 'Almacén 5', 'Calle Almacén, 90');

INSERT INTO composicion_piezas (id_pieza, componente)
VALUES
(1, 2),
(1, 3),
(2, 1),
(2, 3),
(3, 1),
(3, 2),
(4, 5),
(4, 6),
(5, 1),
(5, 3),
(6, 2),
(6, 3),
(7, 4),
(7, 5),
(8, 1),
(8, 2),
(9, 3),
(9, 4),
(10, 5),
(10, 6);

INSERT INTO almacenamiento (id, id_estanteria, id_pieza, cantidad)
VALUES
(1, 1, 1, 100),
(2, 2, 2, 150),
(3, 3, 3, 200),
(4, 4, 4, 50),
(5, 5, 5, 80),
(6, 6, 6, 20),
(7, 7, 7, 30),
(8, 8, 8, 10),
(9, 9, 9, 25),
(10, 10, 10, 100);
