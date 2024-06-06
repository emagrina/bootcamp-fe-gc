INSERT INTO nominas (id, fecha, salario) VALUES
(1, '2023-07-01', 2500.50),
(2, '2023-07-02', 2800.75),
(3, '2023-07-03', 3000.00),
(4, '2023-07-04', 2200.20),
(5, '2023-07-05', 2600.35),
(6, '2023-07-06', 2700.80),
(7, '2023-07-07', 2900.60),
(8, '2023-07-08', 3100.45),
(9, '2023-07-09', 2400.90),
(10, '2023-07-10', 3200.25);

INSERT INTO trabajadores (dni, num_seguridad_social, codigo, nombre, apellidos, direccion, telefono, id_nomina) VALUES
('11111111A', '1234567890', 1001, 'Juan', 'Perez', 'Calle Mayor 1', '123456789', 1),
('22222222B', '0987654321', 1002, 'Ana', 'Lopez', 'Plaza España 5', '987654321', 2),
('33333333C', '5678901234', 1003, 'Pedro', 'Gomez', 'Avenida Libertad 10', '567890123', 3),
('44444444D', '4567890123', 1004, 'Maria', 'Martinez', 'Calle Rioja 8', '456789012', 4),
('55555555E', '3456789012', 1005, 'Luis', 'Sanchez', 'Paseo del Prado 15', '345678901', 5),
('66666666F', '2345678901', 1006, 'Laura', 'Fernandez', 'Calle Gran Via 20', '234567890', 6),
('77777777G', '0123456789', 1007, 'Carlos', 'Ramirez', 'Plaza del Sol 25', '012345678', 7),
('88888888H', '9876543210', 1008, 'Marta', 'Jimenez', 'Avenida del Mar 30', '987654321', 8),
('99999999I', '8765432109', 1009, 'Antonio', 'Soto', 'Calle Alcala 35', '876543210', 9),
('10101010J', '7654321098', 1010, 'Elena', 'Rios', 'Plaza Mayor 40', '765432109', 10);

INSERT INTO departamentos (codigo, nombre, dni_trabajador) VALUES
(2001, 'Recursos Humanos', '11111111A'),
(2002, 'Contabilidad', '22222222B'),
(2003, 'Ventas', '33333333C'),
(2004, 'Producción', '44444444D'),
(2005, 'Marketing', '55555555E'),
(2006, 'Logística', '66666666F'),
(2007, 'Informática', '77777777G'),
(2008, 'Atención al Cliente', '88888888H'),
(2009, 'Calidad', '99999999I'),
(2010, 'Administración', '10101010J');

INSERT INTO categoria_profesional (id, nombre, dni_trabajador) VALUES
(3001, 'Técnico', '11111111A'),
(3002, 'Administrativo', '22222222B'),
(3003, 'Comercial', '33333333C'),
(3004, 'Operario', '44444444D'),
(3005, 'Marketing', '55555555E'),
(3006, 'Analista', '66666666F'),
(3007, 'Programador', '77777777G'),
(3008, 'Asesor', '88888888H'),
(3009, 'Inspector', '99999999I'),
(3010, 'Auxiliar', '10101010J');

INSERT INTO contrato (id, fecha_inicio, fecha_final, dni_trabajador) VALUES
(4001, '2023-07-01', '2024-06-30', '11111111A'),
(4002, '2023-07-02', '2024-07-01', '22222222B'),
(4003, '2023-07-03', '2024-07-02', '33333333C'),
(4004, '2023-07-04', '2024-07-03', '44444444D'),
(4005, '2023-07-05', '2024-07-04', '55555555E'),
(4006, '2023-07-06', '2024-07-05', '66666666F'),
(4007, '2023-07-07', '2024-07-06', '77777777G'),
(4008, '2023-07-08', '2024-07-07', '88888888H'),
(4009, '2023-07-09', '2024-07-08', '99999999I'),
(4010, '2023-07-10', '2024-07-09', '10101010J');