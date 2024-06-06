INSERT INTO menus (id, fecha, num_personas, temperatura_dia) VALUES
(1, '2023-07-31', 4, 30.5),
(2, '2023-08-01', 2, 25.0),
(3, '2023-08-02', 6, 28.2),
(4, '2023-08-03', 3, 29.8),
(5, '2023-08-04', 5, 26.7),
(6, '2023-08-05', 4, 31.1),
(7, '2023-08-06', 2, 24.9),
(8, '2023-08-07', 7, 27.3),
(9, '2023-08-08', 3, 29.0),
(10, '2023-08-09', 4, 30.8);

INSERT INTO platos (id, nombre, descripcion) VALUES
(1, 'Pasta Carbonara', 'Deliciosa pasta con salsa de huevo, panceta y queso.'),
(2, 'Pollo Asado', 'Pollo asado al horno con especias y hierbas.'),
(3, 'Ensalada César', 'Ensalada fresca con lechuga, pollo, croutones y aderezo César.'),
(4, 'Sushi Variado', 'Variedad de sushi de salmón, atún y aguacate.'),
(5, 'Pizza Margarita', 'Pizza con salsa de tomate, mozzarella y albahaca.'),
(6, 'Tacos de Carne Asada', 'Tacos con carne asada, cebolla y cilantro.'),
(7, 'Sopa de Tomate', 'Sopa caliente de tomate con albahaca.'),
(8, 'Paella Valenciana', 'Plato de arroz con mariscos y carne.'),
(9, 'Tarta de Manzana', 'Tarta dulce de manzana con canela.'),
(10, 'Helado de Vainilla', 'Helado cremoso de vainilla.');

INSERT INTO menus_platos (id_menu, id_plato) VALUES 
(1, 3), 
(1, 6),
(2, 1),
(3, 2), 
(3, 4), 
(3, 9),
(4, 5), 
(4, 8),
(5, 7), 
(5, 10),
(6, 3), 
(6, 5), 
(6, 6),
(7, 2), 
(7, 9),
(8, 1), 
(8, 4), 
(8, 8),
(9, 6), 
(9, 7),
(10, 10);

