USE ex02;

INSERT INTO temas (nombre) VALUES
('Fantasía'),
('Ciencia ficción'),
('Romance'),
('Aventura'),
('Misterio'),
('Historia'),
('Biografía');

INSERT INTO autores (nombre) VALUES
('Antoine de Saint-Exupéry'),
('Harper Lee'),
('Gabriel García Márquez'),
('George Orwell'),
('J.K. Rowling'),
('Miguel de Cervantes'),
('Jane Austen'),
('F. Scott Fitzgerald'),
('Herman Melville'),
('Fyodor Dostoevsky');

INSERT INTO editoriales (nombre, direccion, telefono) VALUES
('Editorial A', 'Calle 1, Ciudad A', '123456789'),
('Editorial B', 'Calle 2, Ciudad B', '987654321'),
('Editorial C', 'Calle 3, Ciudad C', '456789123');
    
INSERT INTO libros (titulo, idioma, formato, clave_editorial) VALUES
('El Principito', 'Español', 'Físico', 1),
('To Kill a Mockingbird', 'Inglés', 'Digital', 2),
('Cien años de soledad', 'Español', 'Físico', 1),
('1984', 'Inglés', 'Digital', 3),
('Harry Potter and the Sorcerer''s Stone', 'Inglés', 'Físico', 2),
('Don Quijote de la Mancha', 'Español', 'Físico', 1),
('Pride and Prejudice', 'Inglés', 'Digital', 2),
('The Great Gatsby', 'Inglés', 'Físico', 3),
('Moby-Dick', 'Inglés', 'Físico', 3),
('Crime and Punishment', 'Inglés', 'Digital', 2);

INSERT INTO ejemplares (clave_libro, numero_orden, edicion, ubicacion, categoria) VALUES
(1, 1001, 'Primera', 'Estante 1', 'Fantasía'),
(2, 1002, 'Segunda', 'Estante 2', 'Misterio'),
(3, 1003, 'Tercera', 'Estante 3', 'Romance'),
(4, 1004, 'Cuarta', 'Estante 4', 'Ciencia ficción'),
(5, 1005, 'Quinta', 'Estante 5', 'Aventura'),
(6, 1006, 'Sexta', 'Estante 1', 'Historia'),
(7, 1007, 'Séptima', 'Estante 2', 'Romance'),
(8, 1008, 'Octava', 'Estante 3', 'Misterio'),
(9, 1009, 'Novena', 'Estante 4', 'Fantasía'),
(10, 1010, 'Décima', 'Estante 5', 'Ciencia ficción');


INSERT INTO socios (nombre, direccion, telefono, categoria) VALUES
('Socio 1', 'Calle A, Ciudad A', '111111111', 'Estudiante'),
('Socio 2', 'Calle B, Ciudad B', '222222222', 'Estudiante'),
('Socio 3', 'Calle C, Ciudad C', '333333333', 'Profesor'),
('Socio 4', 'Calle D, Ciudad D', '444444444', 'Profesor'),
('Socio 5', 'Calle E, Ciudad E', '555555555', 'Estudiante'),
('Socio 6', 'Calle F, Ciudad F', '666666666', 'Estudiante'),
('Socio 7', 'Calle G, Ciudad G', '777777777', 'Estudiante'),
('Socio 8', 'Calle H, Ciudad H', '888888888', 'Profesor'),
('Socio 9', 'Calle I, Ciudad I', '999999999', 'Profesor'),
('Socio 10', 'Calle J, Ciudad J', '101010101', 'Estudiante');

INSERT INTO prestamos (clave_socio, clave_ejemplar, numero_orden, fecha_prestamo, fecha_devolucion, notas) VALUES
(1, 1, 1, '2023-07-31', '2023-08-07', 'Prestamo 1'),
(2, 2, 2, '2023-07-31', '2023-08-14', 'Prestamo 2'),
(3, 3, 3, '2023-07-31', '2023-08-21', 'Prestamo 3'),
(4, 4, 4, '2023-07-31', '2023-08-28', 'Prestamo 4'),
(5, 5, 5, '2023-07-31', '2023-09-04', 'Prestamo 5'),
(6, 6, 6, '2023-07-31', '2023-09-11', 'Prestamo 6'),
(7, 7, 7, '2023-07-31', '2023-09-18', 'Prestamo 7'),
(8, 8, 8, '2023-07-31', '2023-09-25', 'Prestamo 8'),
(9, 9, 9, '2023-07-31', '2023-10-02', 'Prestamo 9'),
(10, 10, 10, '2023-07-31', '2023-10-09', 'Prestamo 10');

INSERT INTO tratas_sobre (clave_libro, clave_tema) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 1),
(9, 2),
(10, 3);

INSERT INTO escrito_por (clave_libro, clave_autor) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);
