CREATE DATABASE IF NOT EXISTS ex11;

USE ex11;

CREATE TABLE facultades (
    codigo INT PRIMARY KEY,
    nombre NVARCHAR(100)
);

CREATE TABLE equipos (
    num_serie CHAR(4) PRIMARY KEY,
    nombre NVARCHAR(100),
    facultat INT,
    FOREIGN KEY (facultat) REFERENCES facultades(codigo)
);

CREATE TABLE investigadores (
    dni VARCHAR(8) PRIMARY KEY,
    nom_apels NVARCHAR(255),
    facultat INT,
    FOREIGN KEY (facultat) REFERENCES facultades(codigo)
);

CREATE TABLE reservas (
    dni VARCHAR(8),
    num_serie CHAR(4),
    comienzo DATETIME,
    fin DATETIME,
    PRIMARY KEY (dni, num_serie),
    FOREIGN KEY (dni) REFERENCES investigadores(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (num_serie) REFERENCES equipos(num_serie) ON UPDATE CASCADE ON DELETE CASCADE
);