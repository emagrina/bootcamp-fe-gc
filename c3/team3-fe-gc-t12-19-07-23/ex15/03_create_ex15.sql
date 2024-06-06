CREATE DATABASE IF NOT EXISTS ex15;

USE ex15;

CREATE TABLE menus (
    id INT PRIMARY KEY,
    fecha DATE,
    num_personas INT,
    temperatura_dia FLOAT
);

CREATE TABLE platos (
    id INT PRIMARY KEY,
    nombre VARCHAR(255),
    descripcion VARCHAR(500)
);

CREATE TABLE menus_platos (
    id_menu INT,
    id_plato INT,
    PRIMARY KEY (id_menu, id_plato),
    FOREIGN KEY (id_menu) REFERENCES menus(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_plato) REFERENCES platos(id) ON UPDATE CASCADE ON DELETE CASCADE
);