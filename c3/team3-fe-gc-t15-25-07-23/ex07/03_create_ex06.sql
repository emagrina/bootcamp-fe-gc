CREATE DATABASE IF NOT EXISTS ex07;
USE ex07;

CREATE TABLE despachos (
    numero INT PRIMARY KEY,
    capacidad INT
);

CREATE TABLE directores (
    dni VARCHAR(8) PRIMARY KEY,
    nom_apels NVARCHAR(255),
    dni_jefe VARCHAR(8),
    despacho INT,
    FOREIGN KEY (dni_jefe) REFERENCES directores(dni) ON UPDATE CASCADE ON DELETE SET CASCADE,
    FOREIGN KEY (despacho) REFERENCES despachos(numero) ON UPDATE CASCADE ON DELETE SET CASCADE
);
