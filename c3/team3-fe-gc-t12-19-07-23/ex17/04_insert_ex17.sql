INSERT INTO horarios (dia_semana, hora, codigo)
VALUES 
('2023-07-31', '08:00:00', 1),
('2023-08-01', '09:30:00', 2),
('2023-08-02', '14:15:00', 3),
('2023-08-03', '16:45:00', 4),
('2023-08-04', '11:30:00', 5),
('2023-08-05', '10:00:00', 6),
('2023-08-06', '12:30:00', 7),
('2023-08-07', '13:45:00', 8),
('2023-08-08', '15:15:00', 9),
('2023-08-09', '17:00:00', 10);


INSERT INTO aulas (numero, codigo, metros_cuadrados)
VALUES 
(101, 1001, 50),
(102, 1002, 40),
(103, 1003, 55),
(104, 1004, 48),
(105, 1005, 52),
(106, 1006, 45),
(107, 1007, 47),
(108, 1008, 42),
(109, 1009, 60),
(110, 1010, 38);

INSERT INTO asignaturas (codigo_interno_centro, nombre, codigo_europeo, curso_ciclo, codigo_interno_curso, numero_aula)
VALUES 
(1001, 'Matemáticas', 2001, '1º Bachillerato', 5001, 101),
(1002, 'Física', 2002, '2º Bachillerato', 5002, 102),
(1003, 'Historia', 2003, '3º ESO', 5003, 103),
(1004, 'Química', 2004, '4º ESO', 5004, 104),
(1005, 'Literatura', 2005, '1º Bachillerato', 5001, 105),
(1006, 'Inglés', 2006, '2º Bachillerato', 5002, 106),
(1007, 'Biología', 2007, '3º ESO', 5003, 107),
(1008, 'Geografía', 2008, '4º ESO', 5004, 108),
(1009, 'Historia del Arte', 2009, '1º Bachillerato', 5001, 109),
(1010, 'Música', 2010, '2º Bachillerato', 5002, 110);

INSERT INTO horarios_asignaturas (codigo_horario, codigo_interno_centro)
VALUES 
(1, 1001),
(3, 1003),
(2, 1002),
(4, 1004),
(5, 1005),
(6, 1006),
(7, 1007),
(8, 1008),
(9, 1009),
(10, 1010);

INSERT INTO aulas_asignaturas (numero_aula, codigo_interno_centro)
VALUES 
(101, 1001),
(103, 1003),
(102, 1002),
(104, 1004),
(105, 1005),
(106, 1006),
(107, 1007),
(108, 1008),
(109, 1009),
(110, 1010);

INSERT INTO asignaturas_requeridas (codigo_interno_centro, asignatura_requerida)
VALUES 
(1001, 'Física'),
(1002, 'Matemáticas'),
(1003, 'Biología'),
(1004, 'Química'),
(1005, 'Historia'),
(1006, 'Inglés'),
(1007, 'Geografía'),
(1008, 'Historia del Arte'),
(1009, 'Música'),
(1010, 'Literatura');

INSERT INTO profesores (codigo_interno_profesor, nombre, telefono, email, dni, numero_seguridad_social, antiguedad_impartiendo_asignatura, anos_antiguedad_tutor, inicio_de_enseñamiento, cese_de_enseñamiento)
VALUES 
(2001, 'Pedro Gómez', 987654321, 'pedro@example.com', '12345678A', '1234567890', '2000-01-01', '2015-01-01', '2010-01-01', NULL),
(2002, 'Laura Sánchez', 654987321, 'laura@example.com', '98765432B', '0987654321', '2005-05-10', '2018-02-01', '2013-07-15', NULL),
(2003, 'Carlos Martínez', 789123456, 'carlos@example.com', '56789012C', '0987123456', '2010-09-20', '2021-05-05', '2015-09-20', NULL),
(2004, 'María Rodríguez', 654123789, 'maria@example.com', '87654321D', '1234567890', '2003-03-15', '2019-06-30', '2012-02-15', NULL),
(2005, 'Javier López', 987654123, 'javier@example.com', '90123456E', '5678901234', '2008-11-30', '2017-03-20', '2013-05-01', NULL),
(2006, 'Ana Gutiérrez', 654789321, 'ana@example.com', '12345678F', '4567890123', '2015-07-01', '2022-04-25', '2019-08-01', NULL),
(2007, 'José Ramírez', 789321654, 'jose@example.com', '87654321G', '1234567890', '2013-03-10', '2018-06-10', '2014-03-10', NULL),
(2008, 'Sara Fernández', 987321654, 'sara@example.com', '56789123H', '0987654321', '2011-12-05', '2016-12-05', '2012-02-01', NULL),
(2009, 'Manuel Torres', 654321789, 'manuel@example.com', '98765432I', '0987123456', '2014-08-25', '2019-11-20', '2018-01-01', NULL),
(2010, 'Elena Ramírez', 789654321, 'elena@example.com', '34567890J', '7890123456', '2009-04-15', '2016-03-30', '2011-06-01', NULL);

INSERT INTO profesores_asignaturas (codigo_interno_profesor, codigo_interno_centro)
VALUES 
(2001, 1001),
(2002, 1002),
(2003, 1003),
(2004, 1004),
(2005, 1005),
(2006, 1006),
(2007, 1007),
(2008, 1008),
(2009, 1009),
(2010, 1010);

INSERT INTO ciclos (codigo_interno_curso, nombre, tipo_de_grado, codigo_europeo, curso)
VALUES 
(5001, 'Ciencias', 'Grado', 3001, '2023-2024'),
(5002, 'Humanidades', 'Grado', 3002, '2023-2024'),
(5003, 'Ciencias Sociales', 'Grado', 3003, '2023-2024'),
(5004, 'Artes y Letras', 'Grado', 3004, '2023-2024'),
(5005, 'Ciencias de la Salud', 'Grado', 3005, '2023-2024'),
(5006, 'Ingeniería y Tecnología', 'Grado', 3006, '2023-2024'),
(5007, 'Educación', 'Grado', 3007, '2023-2024'),
(5008, 'Ciencias Económicas y Empresariales', 'Grado', 3008, '2023-2024'),
(5009, 'Derecho', 'Grado', 3009, '2023-2024'),
(5010, 'Arquitectura', 'Grado', 3010, '2023-2024');

INSERT INTO profesores_ciclos (codigo_interno_profesor, codigo_interno_curso)
VALUES 
(2001, 5001),
(2002, 5002),
(2003, 5003),
(2004, 5004),
(2005, 5005),
(2006, 5006),
(2007, 5007),
(2008, 5008),
(2009, 5009),
(2010, 5010);

