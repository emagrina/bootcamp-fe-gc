CREATE DATABASE IF NOT EXISTS ex11;
USE ex11;

CREATE TABLE paises (
    nombre VARCHAR(100) PRIMARY KEY,
    extension INT,
    poblacion INT
);

CREATE TABLE accidentes_geograficos (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    posicion_horizontal FLOAT,
    posicion_vertical FLOAT,
    nombre_pais VARCHAR(100),
    FOREIGN KEY (nombre_pais) REFERENCES paises(nombre) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE rios (
    id INT PRIMARY KEY,
    longitud FLOAT,
    FOREIGN KEY (id) REFERENCES accidentes_geograficos(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE montanas (
    id INT PRIMARY KEY,
    altura FLOAT,
    FOREIGN KEY (id) REFERENCES accidentes_geograficos(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE lagos (
    id INT PRIMARY KEY,
    extension FLOAT,
    FOREIGN KEY (id) REFERENCES accidentes_geograficos(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE localidades (
    nombre VARCHAR(100) PRIMARY KEY,
    id_rio INT,
    nombre_pais VARCHAR(100),
    FOREIGN KEY (id_rio) REFERENCES rios(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (nombre_pais) REFERENCES paises(nombre) ON UPDATE CASCADE ON DELETE CASCADE
);
