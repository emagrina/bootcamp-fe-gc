CREATE DATABASE IF NOT EXISTS ex06;

USE ex06;

CREATE TABLE socios (
    codigo_socio INT PRIMARY KEY,
    dni VARCHAR(50),
    nombre VARCHAR(100),
    apellidos VARCHAR(100),
    direccion VARCHAR(200),
    telefonos VARCHAR(200)
);

CREATE TABLE prestamos (
    id INT PRIMARY KEY,
    codigo_socio INT,
    fecha_prestamo DATE,
    fecha_devolucion DATE,
    fecha_tope DATE,
    FOREIGN KEY (codigo_socio) REFERENCES socios(codigo_socio) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE articulos (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(200),
    ano_obra INT,
    resumen_obra VARCHAR(1000),
    deteriorado BOOLEAN,
    comentario_deterioro VARCHAR(500)
);

CREATE TABLE libros (
    articulo_codigo INT PRIMARY KEY,
    numero_paginas INT,
    FOREIGN KEY (articulo_codigo) REFERENCES articulos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE cds (
    articulo_codigo INT PRIMARY KEY,
    numero_canciones INT,
    FOREIGN KEY (articulo_codigo) REFERENCES articulos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE peliculas (
    articulo_codigo INT PRIMARY KEY,
    duracion INT,
    FOREIGN KEY (articulo_codigo) REFERENCES articulos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE autores (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    pais VARCHAR(100)
);

CREATE TABLE interpretes (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    pais VARCHAR(100)
);

CREATE TABLE directores (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    pais VARCHAR(100)
);

CREATE TABLE prestamos_articulos (
    prestamos_id INT,
    articulos_codigo INT,
    PRIMARY KEY (prestamos_id, articulos_codigo),
    FOREIGN KEY (prestamos_id) REFERENCES prestamos(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (articulos_codigo) REFERENCES articulos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE libros_autores (
    libros_codigo INT,
    autores_id INT,
    PRIMARY KEY (libros_codigo, autores_id),
    FOREIGN KEY (libros_codigo) REFERENCES libros(articulo_codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (autores_id) REFERENCES autores(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE cds_interpretes (
    cds_codigo INT,
    interpretes_id INT,
    PRIMARY KEY (cds_codigo, interpretes_id),
    FOREIGN KEY (cds_codigo) REFERENCES cds(articulo_codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (interpretes_id) REFERENCES interpretes(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE peliculas_directores (
    peliculas_codigo INT,
    directores_id INT,
    PRIMARY KEY (peliculas_codigo, directores_id),
    FOREIGN KEY (peliculas_codigo) REFERENCES peliculas(articulo_codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (directores_id) REFERENCES directores(id) ON UPDATE CASCADE ON DELETE CASCADE
);