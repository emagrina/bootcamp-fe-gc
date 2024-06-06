USE ex05;

INSERT INTO almacenes (lugar, capacidad) VALUES
('Almacén A', 200),
('Almacén B', 150),
('Almacén C', 300),
('Almacén D', 250),
('Almacén E', 180),
('Almacén F', 120),
('Almacén G', 400),
('Almacén H', 220),
('Almacén I', 350),
('Almacén J', 280);

INSERT INTO cajas (num_referencia, contenido, valor, almacen) VALUES
('C001', 'Contenido 1', 50, 1),
('C002', 'Contenido 2', 75, 1),
('C003', 'Contenido 3', 100, 2),
('C004', 'Contenido 4', 30, 3),
('C005', 'Contenido 5', 45, 2),
('C006', 'Contenido 6', 60, 4),
('C007', 'Contenido 7', 80, 3),
('C008', 'Contenido 8', 90, 5),
('C009', 'Contenido 9', 70, 4),
('C010', 'Contenido 10', 55, 5);
