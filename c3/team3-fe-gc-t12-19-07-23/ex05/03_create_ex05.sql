CREATE DATABASE IF NOT EXISTS ex05;

USE ex05;

CREATE TABLE pieza (
    id INT PRIMARY KEY,
    descripcion VARCHAR(255),
    precio FLOAT
);

CREATE TABLE almacen (
    id INT PRIMARY KEY,
    descripcion VARCHAR(255),
    direccion VARCHAR(255)
);

CREATE TABLE composicion_piezas (
    id_pieza INT,
    componente INT,
    PRIMARY KEY (id_pieza, componente),
    FOREIGN KEY (id_pieza) REFERENCES pieza(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (componente) REFERENCES pieza(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE almacenamiento (
    id INT PRIMARY KEY,
    id_estanteria INT,
    id_pieza INT,
    cantidad INT,
    FOREIGN KEY (id) REFERENCES almacen(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_estanteria) REFERENCES almacen(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_pieza) REFERENCES pieza(id) ON UPDATE CASCADE ON DELETE CASCADE
);