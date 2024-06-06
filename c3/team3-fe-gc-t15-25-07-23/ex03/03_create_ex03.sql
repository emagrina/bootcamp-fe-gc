CREATE DATABASE IF NOT EXISTS ex03;
USE ex03;

CREATE TABLE fabricantes (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100)
);

CREATE TABLE articulos (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100),
    precio FLOAT,
    fabricante INT,
    FOREIGN KEY (fabricante) REFERENCES fabricantes(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);