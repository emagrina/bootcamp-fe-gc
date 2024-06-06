INSERT INTO empresas (cif, nombre, direccion, telefono, codigo_interno_empresa)
VALUES
('12345678A', 'Empresa 1', 'Calle Ejemplo 1', '123456789', 'E1'),
('87654321B', 'Empresa 2', 'Avenida Demo 2', '987654321', 'E2'),
('56789123C', 'Empresa 3', 'Plaza Test 3', '654321987', 'E3'),
('98765432D', 'Empresa 4', 'Paseo Prueba 4', '321654987', 'E4'),
('45678912E', 'Empresa 5', 'Carretera Simulacion 5', '987321654', 'E5'),
('23456789F', 'Empresa 6', 'Camino Example 6', '654987321', 'E6'),
('34567891G', 'Empresa 7', 'Sendero Muestra 7', '321987654', 'E7'),
('67891234H', 'Empresa 8', 'Vereda Illustracion 8', '987654321', 'E8'),
('78912345I', 'Empresa 9', 'Ruta Modelo 9', '654321987', 'E9'),
('89123456J', 'Empresa 10', 'Autovía Ejemplar 10', '321654987', 'E10');

INSERT INTO proyectos (id, fecha_inicio, fecha_finalizacion, fecha_prevista_finalizacion, cif_empresa)
VALUES
(1, '2023-01-10', '2023-03-20', '2023-03-15', '12345678A'),
(2, '2023-02-15', '2023-04-30', '2023-04-25', '87654321B'),
(3, '2023-03-01', '2023-05-10', '2023-05-05', '56789123C'),
(4, '2023-04-05', '2023-06-15', '2023-06-10', '98765432D'),
(5, '2023-05-20', '2023-07-25', '2023-07-20', '45678912E'),
(6, '2023-06-10', '2023-08-30', '2023-08-25', '23456789F'),
(7, '2023-07-15', '2023-09-10', '2023-09-05', '34567891G'),
(8, '2023-08-20', '2023-10-15', '2023-10-10', '67891234H'),
(9, '2023-09-25', '2023-11-20', '2023-11-15', '78912345I'),
(10, '2023-10-30', '2023-12-25', '2023-12-20', '89123456J');

INSERT INTO profesiones (codigo_profesion, nombre)
VALUES
(1, 'Ingeniero'),
(2, 'Arquitecto'),
(3, 'Diseñador'),
(4, 'Programador'),
(5, 'Contador'),
(6, 'Abogado'),
(7, 'Médico'),
(8, 'Cocinero'),
(9, 'Electricista'),
(10, 'Fontanero');

INSERT INTO trabajadores (codigo_trabajador, dni, nombre, apellidos, codigo_profesion)
VALUES
(100001, '12345678A', 'Juan', 'Gómez', 1),
(100002, '23456789B', 'María', 'López', 2),
(100003, '34567891C', 'Pedro', 'Martínez', 3),
(100004, '45678912D', 'Ana', 'Fernández', 4),
(100005, '56789123E', 'Carlos', 'Rodríguez', 5),
(100006, '67891234F', 'Laura', 'González', 6),
(100007, '78912345G', 'Miguel', 'Pérez', 7),
(100008, '89123456H', 'Sofía', 'Ruiz', 8),
(100009, '91234567I', 'David', 'Sánchez', 9),
(100010, '12345678J', 'Elena', 'Hernández', 10);

INSERT INTO participaciones (codigo_trabajador, id_proyecto, horas_trabajadas)
VALUES
(100001, 1, 80),
(100001, 2, 100),
(100001, 3, 120),
(100002, 2, 90),
(100002, 4, 110),
(100003, 1, 70),
(100003, 3, 95),
(100003, 4, 80),
(100004, 2, 85),
(100004, 5, 115);
