CREATE DATABASE IF NOT EXISTS ex14;
USE ex14;

CREATE TABLE usuarios (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    direccion VARCHAR(100),
    email VARCHAR(100),
    contrasena VARCHAR(100),
    foto VARCHAR(100),
    numero VARCHAR(15)
);

CREATE TABLE contactos (
    id INT PRIMARY KEY,
    numero VARCHAR(15),
    comentario VARCHAR(200)
);

CREATE TABLE grupos (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    cantidad INT
);

CREATE TABLE comentarios (
    id INT PRIMARY KEY,
    texto VARCHAR(500),
    imagen VARCHAR(100),
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE bloqueados (
    id INT PRIMARY KEY,
    id_usuario INT,
    id_bloqueo INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_bloqueo) REFERENCES usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE usuarios_contactos (
    id INT PRIMARY KEY,
    id_usuario INT,
    id_contacto INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_contacto) REFERENCES contactos(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE contacto_grupo (
    id INT PRIMARY KEY,
    id_contacto INT,
    id_grupo INT,
    FOREIGN KEY (id_contacto) REFERENCES contactos(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_grupo) REFERENCES grupos(id) ON DELETE CASCADE ON UPDATE CASCADE
);
