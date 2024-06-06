INSERT INTO socios (codigo_socio, dni, nombre, apellidos, direccion, telefonos)
VALUES
(1, '12345678A', 'Juan', 'Pérez', 'Calle Mayor 123', '+34 123 456 789'),
(2, '98765432B', 'María', 'Gómez', 'Avenida Principal 456', '+34 987 654 321'),
(3, '56789012C', 'Carlos', 'López', 'Plaza Central 789', '+34 555 555 555'),
(4, '90876543D', 'Laura', 'Martínez', 'Calle del Sol 567', '+34 444 444 444'),
(5, '65432198E', 'Ana', 'Rodríguez', 'Avenida Central 890', '+34 888 888 888'),
(6, '45678901F', 'Pedro', 'González', 'Calle del Río 123', '+34 777 777 777'),
(7, '23456789G', 'Elena', 'Sánchez', 'Plaza del Parque 456', '+34 666 666 666'),
(8, '78901234H', 'Diego', 'Fernández', 'Calle de la Luna 789', '+34 222 222 222'),
(9, '34567890I', 'Isabel', 'Hernández', 'Avenida de la Montaña 012', '+34 999 999 999'),
(10, '90123456J', 'Andrés', 'Ruíz', 'Calle del Mar 345', '+34 333 333 333');

INSERT INTO prestamos (id, codigo_socio, fecha_prestamo, fecha_devolucion, fecha_tope)
VALUES
(1, 1, '2023-07-15', '2023-07-22', '2023-07-29'),
(2, 2, '2023-07-20', '2023-08-03', '2023-08-10'),
(3, 3, '2023-07-25', '2023-08-01', '2023-08-08'),
(4, 4, '2023-07-10', '2023-07-20', '2023-07-27'),
(5, 5, '2023-07-18', '2023-07-25', '2023-08-01'),
(6, 6, '2023-07-22', '2023-07-30', '2023-08-06'),
(7, 7, '2023-07-12', '2023-07-19', '2023-07-26'),
(8, 8, '2023-07-29', '2023-08-05', '2023-08-12'),
(9, 9, '2023-07-14', '2023-07-21', '2023-07-28'),
(10, 10, '2023-07-27', '2023-08-03', '2023-08-10');

INSERT INTO articulos (codigo, nombre, ano_obra, resumen_obra, deteriorado, comentario_deterioro)
VALUES
(1, 'Libro de Aventuras', 2005, 'Un libro emocionante sobre un viaje épico.', 0, NULL),
(2, 'CD de Música Clásica', 1998, 'Una colección de obras maestras de la música clásica.', 1, 'Pequeño rasguño en la portada.'),
(3, 'Película de Ciencia Ficción', 2010, 'Una emocionante aventura en el espacio exterior.', 0, NULL),
(4, 'Novela Romántica', 2015, 'Una historia de amor que cautivará tu corazón.', 0, NULL),
(5, 'CD de Rock', 2003, 'Los éxitos más grandes de la era del rock.', 0, NULL),
(6, 'Película de Drama', 2018, 'Una emotiva historia de superación personal.', 1, 'Pequeña grieta en el estuche.'),
(7, 'Libro de Misterio', 2012, 'Un enigma por resolver que te mantendrá en vilo.', 0, NULL),
(8, 'CD de Pop', 2001, 'Los mejores éxitos pop de todos los tiempos.', 0, NULL),
(9, 'Película de Acción', 2016, 'Emocionantes escenas de acción y aventuras.', 0, NULL),
(10, 'Libro de Ciencia', 2019, 'Un fascinante recorrido por los misterios del universo.', 0, NULL);

INSERT INTO libros (articulo_codigo, numero_paginas)
VALUES
(1, 320),
(4, 280),
(7, 400),
(10, 260);

INSERT INTO cds (articulo_codigo, numero_canciones)
VALUES
(2, 12),
(5, 10),
(8, 15);

INSERT INTO peliculas (articulo_codigo, duracion)
VALUES
(3, 150),
(6, 120),
(9, 180);

INSERT INTO autores (id, nombre, pais)
VALUES
(1, 'J.K. Rowling', 'Reino Unido'),
(2, 'Gabriel García Márquez', 'Colombia'),
(3, 'Jane Austen', 'Reino Unido'),
(4, 'Paula Hawkins', 'Reino Unido'),
(5, 'Haruki Murakami', 'Japón'),
(6, 'Isabel Allende', 'Chile'),
(7, 'Stephen King', 'Estados Unidos'),
(8, 'J.R.R. Tolkien', 'Reino Unido'),
(9, 'Agatha Christie', 'Reino Unido'),
(10, 'George Orwell', 'Reino Unido');

INSERT INTO interpretes (id, nombre, pais)
VALUES
(1, 'Ludwig van Beethoven', 'Alemania'),
(2, 'Adele', 'Reino Unido'),
(3, 'Carlos Santana', 'Estados Unidos'),
(4, 'Queen', 'Reino Unido'),
(5, 'The Beatles', 'Reino Unido'),
(6, 'Michael Jackson', 'Estados Unidos'),
(7, 'Madonna', 'Estados Unidos'),
(8, 'Bob Marley', 'Jamaica'),
(9, 'Elvis Presley', 'Estados Unidos'),
(10, 'Beyoncé', 'Estados Unidos');


INSERT INTO directores (id, nombre, pais)
VALUES
(1, 'Christopher Nolan', 'Reino Unido'),
(2, 'Quentin Tarantino', 'Estados Unidos'),
(3, 'Hayao Miyazaki', 'Japón'),
(4, 'Steven Spielberg', 'Estados Unidos'),
(5, 'Martin Scorsese', 'Estados Unidos'),
(6, 'James Cameron', 'Canadá'),
(7, 'Tim Burton', 'Estados Unidos'),
(8, 'Ridley Scott', 'Reino Unido'),
(9, 'Alfred Hitchcock', 'Reino Unido'),
(10, 'Francis Ford Coppola', 'Estados Unidos');

INSERT INTO prestamos_articulos (prestamos_id, articulos_codigo)
VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);

INSERT INTO libros_autores (libros_codigo, autores_id)
VALUES
(1, 1),
(4, 2),
(7, 3),
(10, 4);


INSERT INTO cds_interpretes (cds_codigo, interpretes_id)
VALUES
(2, 1),
(5, 2),
(8, 3);

INSERT INTO peliculas_directores (peliculas_codigo, directores_id)
VALUES
(3, 1),
(6, 2),
(9, 3);