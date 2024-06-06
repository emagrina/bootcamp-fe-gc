INSERT INTO empleados (dni, nombre, apellidos, numero_seguridad_social, telefono_fijo, telefono_movil, tipo_empleado)
VALUES
(100001, 'Juan', 'Gómez', '1234567890', '912345678', '612345678', 'Cocinero'),
(100002, 'María', 'López', '0987654321', '911234567', '611234567', 'Cocinero'),
(100003, 'Carlos', 'Fernández', '5432167890', '912345679', '612345679', 'Cocinero'),
(100004, 'Ana', 'Martínez', '9876543210', '912345670', '612345670', 'Pinche'),
(100005, 'Pedro', 'Rodríguez', '0123456789', '912345671', '612345671', 'Pinche'),
(100006, 'Laura', 'García', '2345678901', '912345672', '612345672', 'Pinche'),
(100007, 'José', 'Ramírez', '4567890123', '912345673', '612345673', 'Cocinero'),
(100008, 'Carmen', 'Pérez', '6789012345', '912345674', '612345674', 'Cocinero'),
(100009, 'Diego', 'Sánchez', '9012345678', '912345675', '612345675', 'Cocinero'),
(100010, 'Elena', 'Gutiérrez', '5432109876', '912345676', '612345676', 'Pinche');

INSERT INTO cocineros (dni, anos_servicio, dni_empleado)
VALUES
(100001, 5, 100001),
(100002, 8, 100002),
(100003, 3, 100003),
(100007, 6, 100007);

INSERT INTO pinches (dni, fecha_nacimiento, dni_cocinero, dni_empleado)
VALUES
(100004, '1995-03-15', 100001, 100004),
(100005, '1998-07-22', 100001, 100005),
(100006, '1997-11-10', 100002, 100006),
(100010, '1999-02-28', 100002, 100010);

INSERT INTO platos (id, nombre, precio, tipo_plato)
VALUES
(1, 'Pasta Carbonara', 12.50, 'Principal'),
(2, 'Ensalada César', 8.75, 'Entrante'),
(3, 'Tarta de Chocolate', 6.99, 'Postre'),
(4, 'Paella Valenciana', 15.25, 'Principal'),
(5, 'Sopa de Verduras', 7.50, 'Entrante'),
(6, 'Flan de Vainilla', 5.50, 'Postre'),
(7, 'Lasaña Bolognesa', 13.75, 'Principal'),
(8, 'Gazpacho Andaluz', 6.25, 'Entrante'),
(9, 'Helado de Fresa', 4.99, 'Postre'),
(10, 'Sushi Variado', 18.50, 'Principal');

INSERT INTO ingredientes (id, nombre)
VALUES
(1, 'Spaghetti'),
(2, 'Huevos'),
(3, 'Bacon'),
(4, 'Lechuga'),
(5, 'Pollo'),
(6, 'Pan'),
(7, 'Arroz'),
(8, 'Calamares'),
(9, 'Tomate'),
(10, 'Chocolate');

INSERT INTO almacenes (id, nombre, descripcion)
VALUES
(1, 'Almacén Principal', 'Almacén central de la cocina'),
(2, 'Almacén de Frutas y Verduras', 'Almacén especializado en frutas y verduras'),
(3, 'Almacén de Carnes', 'Almacén para almacenar carnes frescas y refrigeradas'),
(4, 'Almacén de Lácteos', 'Almacén para almacenar productos lácteos');

INSERT INTO estantes (id, letras, tamano, id_almacen)
VALUES
(1, 'A', 'Pequeño', 2),
(2, 'B', 'Mediano', 2),
(3, 'C', 'Grande', 3),
(4, 'D', 'Pequeño', 3),
(5, 'A', 'Pequeño', 4),
(6, 'B', 'Mediano', 4),
(7, 'C', 'Grande', 4),
(8, 'D', 'Pequeño', 4),
(9, 'A', 'Pequeño', 1),
(10, 'B', 'Mediano', 1);

INSERT INTO cocineros_platos (dni_cocinero, id_plato)
VALUES
(100001, 1),
(100001, 4),
(100003, 2),
(100003, 3),
(100007, 5),
(100007, 6),
(100007, 7),
(100002, 8),
(100002, 9),
(100002, 10);

INSERT INTO platos_ingredientes (id_plato, id_ingrediente, cantidad)
VALUES
(1, 1, 200),
(1, 2, 2),
(1, 3, 100),
(2, 4, 150),
(2, 5, 100),
(3, 10, 50),
(4, 7, 300),
(4, 8, 200),
(4, 9, 50),
(5, 6, 100);

INSERT INTO ingredientes_estantes (id_ingrediente, id_estante, cantidad)
VALUES
(1, 1, 100),
(1, 2, 150),
(2, 3, 50),
(3, 4, 100),
(4, 5, 80),
(5, 6, 120),
(6, 7, 30),
(7, 8, 50),
(8, 9, 70),
(9, 10, 40);
