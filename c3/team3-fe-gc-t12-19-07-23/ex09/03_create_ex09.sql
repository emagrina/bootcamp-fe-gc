CREATE DATABASE IF NOT EXISTS ex09;

USE ex09;

CREATE TABLE recetas (
    id INT PRIMARY KEY,
    nombre VARCHAR(255),
    descripcion VARCHAR(500),
    instrucciones VARCHAR(1000),
    tiempo INT,
    dificultad VARCHAR(50)
);

CREATE TABLE chefs (
    id INT PRIMARY KEY,
    nombre VARCHAR(255),
    nacionalidad VARCHAR(100),
    id_receta INT,
    FOREIGN KEY (id_receta) REFERENCES recetas(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE etiquetas (id INT PRIMARY KEY, nombre VARCHAR(255));

CREATE TABLE ingredientes (
    id INT PRIMARY KEY,
    nombre VARCHAR(255),
    cantidad DECIMAL(10, 2),
    unidad_medida VARCHAR(50)
);

CREATE TABLE categorias (
    id INT PRIMARY KEY,
    nombre VARCHAR(255),
    id_ingrediente INT,
    FOREIGN KEY (id_ingrediente) REFERENCES ingredientes(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE recetas_ingredientes (
    id INT PRIMARY KEY,
    id_receta INT,
    id_ingrediente INT,
    FOREIGN KEY (id_receta) REFERENCES recetas(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_ingrediente) REFERENCES ingredientes(id) ON DELETE CASCADE ON UPDATE CASCADE
);