INSERT INTO recetas (id, nombre, descripcion, instrucciones, tiempo, dificultad)
VALUES
(1, 'Ensalada César', 'Ensalada clásica con pollo', '1. Lavar y cortar la lechuga. 2. Cocinar el pollo y cortarlo en tiras. 3. Preparar la salsa mezclando todos los ingredientes. 4. Mezclar todo.', 30, 'Fácil'),
(2, 'Spaghetti Carbonara', 'Pasta con salsa de huevo', '1. Cocinar la pasta. 2. Preparar la salsa con huevo, queso y panceta. 3. Mezclar todo.', 25, 'Medio'),
(3, 'Tarta de Manzana', 'Postre con manzanas', '1. Preparar la masa. 2. Pelar y cortar las manzanas. 3. Hornear.', 45, 'Difícil'),
(4, 'Pollo al Curry', 'Pollo con salsa de curry', '1. Cocinar el pollo. 2. Preparar la salsa de curry. 3. Mezclar todo.', 40, 'Medio'),
(5, 'Pizza Margherita', 'Pizza clásica italiana', '1. Preparar la masa. 2. Agregar salsa de tomate y queso. 3. Hornear.', 35, 'Fácil'),
(6, 'Sushi', 'Comida japonesa', '1. Cocinar el arroz. 2. Cortar el pescado. 3. Armar los rollos.', 50, 'Difícil'),
(7, 'Pastel de Chocolate', 'Postre de chocolate', '1. Preparar la masa. 2. Hacer el relleno de chocolate. 3. Hornear.', 60, 'Medio'),
(8, 'Risotto de Champiñones', 'Arroz con champiñones', '1. Cocinar el arroz con caldo de champiñones. 2. Saltear los champiñones. 3. Mezclar todo.', 40, 'Medio'),
(9, 'Galletas de Avena', 'Galletas saludables', '1. Mezclar los ingredientes secos. 2. Agregar los ingredientes húmedos. 3. Hornear.', 20, 'Fácil'),
(10, 'Tacos de Carne Asada', 'Tacos mexicanos', '1. Cocinar la carne asada. 2. Preparar las tortillas y los ingredientes. 3. Armar los tacos.', 35, 'Fácil');

INSERT INTO chefs (id, nombre, nacionalidad, id_receta)
VALUES
(1, 'Juan Pérez', 'Mexicana', 10),
(2, 'Maria Gonzalez', 'Italiana', 2),
(3, 'Laura Smith', 'Americana', 5),
(4, 'Carlos Gómez', 'Mexicana', 1),
(5, 'Sofia Martínez', 'Española', 3),
(6, 'Thomas Johnson', 'Francesa', 6),
(7, 'Emma Williams', 'Inglesa', 8),
(8, 'Manuel López', 'Mexicana', 4),
(9, 'Isabella Rodriguez', 'Italiana', 7),
(10, 'Miguel Torres', 'Española', 9);

INSERT INTO etiquetas (id, nombre)
VALUES
(1, 'Vegetariana'),
(2, 'Postre'),
(3, 'Picante'),
(4, 'Saludable'),
(5, 'Tradicional'),
(6, 'Sin Gluten'),
(7, 'Aperitivo'),
(8, 'Casera'),
(9, 'Fusión'),
(10, 'Asiática');

INSERT INTO ingredientes (id, nombre, cantidad, unidad_medida)
VALUES
(1, 'Lechuga', 1.5, 'kg'),
(2, 'Pollo', 800, 'g'),
(3, 'Pasta', 500, 'g'),
(4, 'Manzanas', 4, 'unidades'),
(5, 'Curry', 2, 'cucharadas'),
(6, 'Tomate', 3, 'unidades'),
(7, 'Arroz', 300, 'g'),
(8, 'Champiñones', 250, 'g'),
(9, 'Avena', 200, 'g'),
(10, 'Carne Asada', 600, 'g');

INSERT INTO categorias (id, nombre, id_ingrediente)
VALUES
(1, 'Ensaladas', 1),
(2, 'Pastas', 3),
(3, 'Postres', 4),
(4, 'Comida Mexicana', 2),
(5, 'Pizzas', 6),
(6, 'Comida Japonesa', 7),
(7, 'Tartas y Pasteles', 4),
(8, 'Arroces', 7),
(9, 'Galletas', 9),
(10, 'Tacos y Burritos', 10);

INSERT INTO recetas_ingredientes (id, id_receta, id_ingrediente)
VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 6),
(5, 3, 4),
(6, 4, 2),
(7, 4, 5),
(8, 5, 6),
(9, 5, 3),
(10, 6, 7);