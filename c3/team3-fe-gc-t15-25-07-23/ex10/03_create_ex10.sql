CREATE DATABASE IF NOT EXISTS ex10;

USE ex10;

CREATE TABLE productos (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    nombre NVARCHAR(100),
    precio INT
);

CREATE TABLE maquinas_registradas (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    piso INT
);

CREATE TABLE cajeros (
    codigo INT AUTO_INCREMENT PRIMARY KEY,
    nom_apels NVARCHAR(255)
);

CREATE TABLE ventas (
    cajero INT,
    maquina INT,
    producto INT,
    PRIMARY KEY (cajero, maquina, producto),
    FOREIGN KEY (cajero) REFERENCES cajeros(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (maquina) REFERENCES maquinas_registradas(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (producto) REFERENCES productos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);