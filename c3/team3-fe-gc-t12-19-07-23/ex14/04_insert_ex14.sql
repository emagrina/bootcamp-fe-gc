INSERT INTO usuarios (id, nombre, direccion, email, contrasena, foto, numero) VALUES
(1, 'Usuario1', 'Direccion1', 'usuario1@example.com', 'password1', 'foto1.jpg', '123456789'),
(2, 'Usuario2', 'Direccion2', 'usuario2@example.com', 'password2', 'foto2.jpg', '987654321'),
(3, 'Usuario3', 'Direccion3', 'usuario3@example.com', 'password3', 'foto3.jpg', '456789123'),
(4, 'Usuario4', 'Direccion4', 'usuario4@example.com', 'password4', 'foto4.jpg', '321654987'),
(5, 'Usuario5', 'Direccion5', 'usuario5@example.com', 'password5', 'foto5.jpg', '567891234'),
(6, 'Usuario6', 'Direccion6', 'usuario6@example.com', 'password6', 'foto6.jpg', '789123456'),
(7, 'Usuario7', 'Direccion7', 'usuario7@example.com', 'password7', 'foto7.jpg', '654987321'),
(8, 'Usuario8', 'Direccion8', 'usuario8@example.com', 'password8', 'foto8.jpg', '321123456'),
(9, 'Usuario9', 'Direccion9', 'usuario9@example.com', 'password9', 'foto9.jpg', '789654321'),
(10, 'Usuario10', 'Direccion10', 'usuario10@example.com', 'password10', 'foto10.jpg', '987321456');

INSERT INTO contactos (id, numero, comentario) VALUES
(1, '111111111', 'Comentario1'),
(2, '222222222', 'Comentario2'),
(3, '333333333', 'Comentario3'),
(4, '444444444', 'Comentario4'),
(5, '555555555', 'Comentario5'),
(6, '666666666', 'Comentario6'),
(7, '777777777', 'Comentario7'),
(8, '888888888', 'Comentario8'),
(9, '999999999', 'Comentario9'),
(10, '101010101', 'Comentario10');

INSERT INTO grupos (id, nombre, cantidad) VALUES
(1, 'Grupo1', 5),
(2, 'Grupo2', 10),
(3, 'Grupo3', 8),
(4, 'Grupo4', 12),
(5, 'Grupo5', 6),
(6, 'Grupo6', 15),
(7, 'Grupo7', 3),
(8, 'Grupo8', 7),
(9, 'Grupo9', 9),
(10, 'Grupo10', 4);

INSERT INTO comentarios (id, texto, imagen, id_usuario) VALUES
(1, 'Comentario1', 'imagen1.jpg', 1),
(2, 'Comentario2', 'imagen2.jpg', 2),
(3, 'Comentario3', 'imagen3.jpg', 3),
(4, 'Comentario4', 'imagen4.jpg', 4),
(5, 'Comentario5', 'imagen5.jpg', 5),
(6, 'Comentario6', 'imagen6.jpg', 6),
(7, 'Comentario7', 'imagen7.jpg', 7),
(8, 'Comentario8', 'imagen8.jpg', 8),
(9, 'Comentario9', 'imagen9.jpg', 9),
(10, 'Comentario10', 'imagen10.jpg', 10);

INSERT INTO bloqueados (id, id_usuario, id_bloqueo) VALUES
(1, 1, 2),
(2, 3, 4),
(3, 5, 6),
(4, 7, 8),
(5, 9, 10),
(6, 2, 1),
(7, 4, 3),
(8, 6, 5),
(9, 8, 7),
(10, 10, 9);

INSERT INTO usuarios_contactos (id, id_usuario, id_contacto) VALUES
(1, 1, 2),
(2, 3, 4),
(3, 5, 6),
(4, 7, 8),
(5, 9, 10),
(6, 2, 1),
(7, 4, 3),
(8, 6, 5),
(9, 8, 7),
(10, 10, 9);

INSERT INTO contacto_grupo (id, id_contacto, id_grupo) VALUES
(1, 1, 2),
(2, 3, 4),
(3, 5, 6),
(4, 7, 8),
(5, 9, 10),
(6, 2, 1),
(7, 4, 3),
(8, 6, 5),
(9, 8, 7),
(10, 10, 9);