CREATE DATABASE IF NOT EXISTS ex16;

USE ex16;

CREATE TABLE usuarios (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    username VARCHAR(50),
    email VARCHAR(100),
    fecha_nac DATE,
    localizacion VARCHAR(100),
    biografia VARCHAR(500),
    url_foto VARCHAR(100),
    total_seguidores INT,
    total_seguidos INT
);

CREATE TABLE mensajes (
    id INT PRIMARY KEY,
    contenido VARCHAR(500),
    fecha DATE
);

CREATE TABLE hashtags (id INT PRIMARY KEY, nombre VARCHAR(50));

CREATE TABLE retweets (
    id INT PRIMARY KEY,
    id_usuario INT,
    id_mensaje INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_mensaje) REFERENCES mensajes(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE publicaciones (
    id INT PRIMARY KEY,
    id_mencion INT,
    id_usuario INT,
    FOREIGN KEY (id_mencion) REFERENCES mensajes(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE mensajes_hashtags (
    id INT PRIMARY KEY,
    id_hastag INT,
    id_mensaje INT,
    FOREIGN KEY (id_hastag) REFERENCES hashtags(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_mensaje) REFERENCES mensajes(id) ON DELETE CASCADE ON UPDATE CASCADE
);