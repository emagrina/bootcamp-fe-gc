CREATE DATABASE IF NOT EXISTS ex05;
USE ex05;

CREATE TABLE almacenes (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    lugar NVARCHAR(100),
    capacidad INT
);

CREATE TABLE cajas (
    num_referencia CHAR(5) PRIMARY KEY,
    contenido NVARCHAR(100),
    valor INT,
    almacen INT,
    FOREIGN KEY (almacen) REFERENCES almacenes(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);