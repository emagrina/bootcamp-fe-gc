INSERT INTO usuarios (id, nombre, username, email, fecha_nac, localizacion, biografia, url_foto, total_seguidores, total_seguidos)
VALUES
(1, 'Juan Pérez', 'juanperez', 'juan@example.com', '1990-05-15', 'Madrid, España', 'Apasionado por la tecnología', 'url_foto1.jpg', 1000, 500),
(2, 'María Gómez', 'mariag', 'maria@example.com', '1985-11-22', 'Barcelona, España', 'Amante de los viajes', 'url_foto2.jpg', 800, 600),
(3, 'Pedro Ramírez', 'pedror', 'pedro@example.com', '1995-08-10', 'Valencia, España', 'Fanático de los deportes', 'url_foto3.jpg', 1200, 900),
(4, 'Ana Martínez', 'anam', 'ana@example.com', '1988-03-28', 'Sevilla, España', 'Gastronomía es mi pasión', 'url_foto4.jpg', 1500, 300),
(5, 'Carlos López', 'carlosl', 'carlos@example.com', '1992-09-03', 'Málaga, España', 'Explorador en bicicleta', 'url_foto5.jpg', 1100, 700),
(6, 'Laura Rodríguez', 'laurar', 'laura@example.com', '1993-06-20', 'Bilbao, España', 'Arte y cultura siempre', 'url_foto6.jpg', 900, 400),
(7, 'David Fernández', 'davidf', 'david@example.com', '1987-12-12', 'Alicante, España', 'Amante de la música', 'url_foto7.jpg', 800, 300),
(8, 'Elena Sánchez', 'elenas', 'elena@example.com', '1998-04-05', 'Granada, España', 'Interesada en la moda', 'url_foto8.jpg', 1300, 500),
(9, 'Mario Ruiz', 'marior', 'mario@example.com', '1991-07-18', 'Zaragoza, España', 'Siempre en movimiento', 'url_foto9.jpg', 950, 600),
(10, 'Carmen Morales', 'carmenm', 'carmen@example.com', '1994-02-25', 'Valencia, España', 'Viajera y soñadora', 'url_foto10.jpg', 1050, 700);

INSERT INTO mensajes (id, contenido, fecha)
VALUES
(1, '¡Hola a todos!', '2023-07-01'),
(2, 'Hoy es un gran día.', '2023-07-02'),
(3, 'Disfrutando del verano.', '2023-07-03'),
(4, 'Feliz cumpleaños!', '2023-07-04'),
(5, 'Nuevo proyecto en marcha.', '2023-07-05'),
(6, 'Aprendiendo nuevas habilidades.', '2023-07-06'),
(7, 'Increíble puesta de sol.', '2023-07-07'),
(8, 'Compartiendo momentos especiales.', '2023-07-08'),
(9, 'En busca de nuevas aventuras.', '2023-07-09'),
(10, 'Construyendo recuerdos.', '2023-07-10');

INSERT INTO hashtags (id, nombre)
VALUES
(1, 'vacaciones'),
(2, 'fotografía'),
(3, 'amigos'),
(4, 'comida'),
(5, 'viajes'),
(6, 'naturaleza'),
(7, 'deporte'),
(8, 'arte'),
(9, 'moda'),
(10, 'musica');

INSERT INTO retweets (id, id_usuario, id_mensaje)
VALUES
(1, 2, 4),
(2, 5, 3),
(3, 8, 1),
(4, 10, 5),
(5, 2, 7),
(6, 1, 9),
(7, 4, 10),
(8, 6, 2),
(9, 9, 6),
(10, 7, 8);

INSERT INTO publicaciones (id, id_mencion, id_usuario)
VALUES
(1, 2, 3),
(2, 4, 5),
(3, 6, 8),
(4, 8, 10),
(5, 10, 2),
(6, 1, 1),
(7, 3, 4),
(8, 5, 6),
(9, 7, 9),
(10, 9, 7);

INSERT INTO mensajes_hashtags (id, id_hastag, id_mensaje)
VALUES
(1, 3, 1),
(2, 5, 3),
(3, 7, 5),
(4, 9, 7),
(5, 2, 2),
(6, 4, 4),
(7, 6, 6),
(8, 8, 8),
(9, 10, 10),
(10, 1, 1);