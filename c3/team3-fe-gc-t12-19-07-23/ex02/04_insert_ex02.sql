INSERT INTO trabajadores (dni, cif, nombre, telefono, direccion_empresa)
VALUES
('123456789', 'CIF12345', 'Juan Pérez', 123456789, 'Calle Mayor 123'),
('987654321', 'CIF98765', 'María Gómez', 987654321, 'Avenida Principal 456'),
('567890123', 'CIF56789', 'Carlos López', 555555555, 'Plaza Central 789'),
('908765432', 'CIF90876', 'Laura Martínez', 444444444, 'Calle del Sol 567'),
('654321987', 'CIF65432', 'Ana Rodríguez', 888888888, 'Avenida Central 890'),
('456789012', 'CIF45678', 'Pedro González', 777777777, 'Calle del Río 123'),
('234567890', 'CIF23456', 'Elena Sánchez', 666666666, 'Plaza del Parque 456'),
('789012345', 'CIF78901', 'Diego Fernández', 222222222, 'Calle de la Luna 789'),
('345678901', 'CIF34567', 'Isabel Hernández', 999999999, 'Avenida de la Montaña 012'),
('901234567', 'CIF90123', 'Andrés Ruíz', 333333333, 'Calle del Mar 345');

INSERT INTO alumnos (dni, direccion, nombre, telefono, edad)
VALUES
('111111111', 'Calle Estudiante 1', 'Luisa Martínez', 111111111, 25),
('222222222', 'Avenida del Conocimiento 2', 'Roberto Gómez', 222222222, 22),
('333333333', 'Plaza del Saber 3', 'María Pérez', 333333333, 20),
('444444444', 'Calle del Aprendizaje 4', 'Daniel López', 444444444, 24),
('555555555', 'Avenida del Sabio 5', 'Ana García', 555555555, 21),
('666666666', 'Calle del Conocimiento 6', 'Carlos Fernández', 666666666, 23),
('777777777', 'Plaza del Estudio 7', 'Laura Ruiz', 777777777, 19),
('888888888', 'Calle del Saber 8', 'David Sánchez', 888888888, 20),
('999999999', 'Avenida del Aprendiz 9', 'Isabel Gómez', 999999999, 21),
('000000000', 'Calle del Conocedor 10', 'Pedro Torres', 000000000, 24);

INSERT INTO cursos (codigo, titulo, programa, horas_duracion)
VALUES
(1, 'Introducción a la Programación', 'Programación básica en varios lenguajes', 40),
(2, 'Diseño Gráfico', 'Principios de diseño y herramientas gráficas', 30),
(3, 'Inglés Intermedio', 'Gramática y vocabulario para nivel intermedio', 50),
(4, 'Marketing Digital', 'Estrategias de marketing en línea', 35),
(5, 'Inteligencia Artificial', 'Conceptos y aplicaciones de IA', 60),
(6, 'Contabilidad Financiera', 'Principios contables y análisis financiero', 45),
(7, 'Gestión de Proyectos', 'Metodologías y herramientas de gestión', 55),
(8, 'Fotografía Básica', 'Principios de composición y manejo de cámara', 25),
(9, 'Diseño Web', 'Creación de sitios web y UX/UI', 40),
(10, 'Economía Microeconómica', 'Teoría de la oferta y demanda', 30);

INSERT INTO profesores (dni, nombre, apellidos, direccion, telefono)
VALUES
('777777777', 'María', 'García', 'Calle del Profesor 1', 777777777),
('888888888', 'Carlos', 'Fernández', 'Avenida de la Enseñanza 2', 888888888),
('999999999', 'Laura', 'Martínez', 'Plaza del Maestro 3', 999999999),
('111111111', 'David', 'López', 'Calle del Conocimiento 4', 111111111),
('222222222', 'Ana', 'Pérez', 'Avenida de la Educación 5', 222222222),
('333333333', 'Pedro', 'Gómez', 'Plaza del Profesorado 6', 333333333),
('444444444', 'Elena', 'Sánchez', 'Calle del Docente 7', 444444444),
('555555555', 'Diego', 'Ruiz', 'Avenida de la Enseñanza 8', 555555555),
('666666666', 'Isabel', 'Fernández', 'Plaza del Maestro 9', 666666666),
('000000000', 'Andrés', 'Gómez', 'Calle del Profesor 10', 000000000);

INSERT INTO trabajadores_alumnos (dni_trabajador, dni_alumno)
VALUES
('123456789', '111111111'),
('987654321', '222222222'),
('567890123', '333333333'),
('908765432', '444444444'),
('654321987', '555555555'),
('456789012', '666666666'),
('234567890', '777777777'),
('789012345', '888888888'),
('345678901', '999999999'),
('901234567', '000000000');

INSERT INTO alumnos_cursos (dni_alumno, codigo_curso, nota)
VALUES
('111111111', 1, 8.5),
('222222222', 2, 7.2),
('333333333', 3, 6.8),
('444444444', 4, 9.1),
('555555555', 5, 8.7),
('666666666', 6, 7.9),
('777777777', 7, 6.5),
('888888888', 8, 9.3),
('999999999', 9, 8.2),
('000000000', 10, 7.7);

INSERT INTO cursos_profesores (dni_profesor, codigo_curso)
VALUES
('777777777', 1),
('888888888', 2),
('999999999', 3),
('111111111', 4),
('222222222', 5),
('333333333', 6),
('444444444', 7),
('555555555', 8),
('666666666', 9),
('000000000', 10);
