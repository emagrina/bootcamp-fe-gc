INSERT INTO profesores (dni, nombre, apellido1, apellido2, direccion, titulo, gana) 
VALUES
('12345678A', 'Juan', 'Pérez', 'González', 'Calle Mayor 123', 'Licenciado en Filología', 2500.50),
('98765432B', 'María', 'López', 'Fernández', 'Avenida Principal 456', 'Doctora en Lingüística', 2800.75),
('45678901C', 'Pedro', 'Ramírez', 'Sánchez', 'Plaza del Sol 789', 'Maestro en Idiomas', 2200.30);

INSERT INTO cursos (cod_curso, nombre_curso, dni_profesor, maximo_alumnos, fecha_inicio, fecha_fin, nom_horas) 
VALUES
(1, 'Curso de Inglés Avanzado', '12345678A', 20, '2023-09-15', '2023-12-15', 120),
(2, 'Curso de Francés Básico', '98765432B', 15, '2023-10-01', '2023-12-01', 90),
(3, 'Curso de Alemán Intermedio', '45678901C', 18, '2023-09-30', '2023-11-30', 100);

INSERT INTO alumnos (dni, nombre, apellido1, apellido2, direccion, sexo, fecha_nacimiento, cod_curso) 
VALUES
('11111111X', 'Laura', 'Gómez', 'Fernández', 'Calle Real 321', 'M', '2000-03-20', 1),
('22222222Y', 'Carlos', 'López', 'García', 'Avenida del Parque 789', 'H', '2002-06-10', 2),
('33333333Z', 'Ana', 'Martínez', 'Sánchez', 'Plaza Mayor 456', 'M', '2001-11-05', 1),
('44444444W', 'David', 'Rodríguez', 'Pérez', 'Calle Principal 753', 'H', '2003-09-25', 3);
