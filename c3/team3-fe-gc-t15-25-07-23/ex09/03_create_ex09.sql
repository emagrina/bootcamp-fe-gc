CREATE DATABASE IF NOT EXISTS ex09;
USE ex09;

CREATE TABLE cientificos (
    dni VARCHAR(8) PRIMARY KEY,
    nom_apels NVARCHAR(255)
);

CREATE TABLE proyectos (
    id CHAR(4) PRIMARY KEY,
    nombre NVARCHAR(255),
    horas INT
);

CREATE TABLE asignado_a (
    cientifico VARCHAR(8),
    proyecto CHAR(4),
    PRIMARY KEY (cientifico, proyecto),
    FOREIGN KEY (cientifico) REFERENCES cientificos(dni) ON UPDATE CASCADE ON DELETE SET CASCADE,
    FOREIGN KEY (proyecto) REFERENCES proyectos(id) ON UPDATE CASCADE ON DELETE SET CASCADE
);