CREATE DATABASE IF NOT EXISTS ex06;
USE ex06;

CREATE TABLE peliculas (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100),
    calificacion_edad INT
);

CREATE TABLE salas (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100),
    pelicula INT,
    FOREIGN KEY (pelicula) REFERENCES peliculas(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);
