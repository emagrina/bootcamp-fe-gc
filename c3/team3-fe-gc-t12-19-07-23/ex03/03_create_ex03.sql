CREATE DATABASE IF NOT EXISTS ex03;

USE ex03;

CREATE TABLE localidades (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    poblacion INT
);

CREATE TABLE comunidades_autonomas (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    poblacion INT,
    superficie FLOAT,
    provincia_codigo_postal_capital INT,
    FOREIGN KEY (provincia_codigo_postal_capital) REFERENCES provincias(codigo_postal) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE provincias (
    codigo_postal INT PRIMARY KEY,
    nombre VARCHAR(50),
    poblacion INT,
    superficie FLOAT,
    comunidad_autonoma_id INT,
    localidades_id_capital INT,
    FOREIGN KEY (comunidad_autonoma_id) REFERENCES comunidades_autonomas(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (localidades_id_capital) REFERENCES localidades(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE localidades_provincias (
    localidades_id INT,
    provincia_codigo_postal INT,
    PRIMARY KEY (localidades_id, provincia_codigo_postal),
    FOREIGN KEY (localidades_id) REFERENCES localidades(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (provincia_codigo_postal) REFERENCES provincias(codigo_postal) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE provincias_comunidades_autonomas (
    provincia_codigo_postal INT,
    provincias_comunidades_autonomas_id INT,
    FOREIGN KEY (provincia_codigo_postal) REFERENCES provincias(codigo_postal) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (comunidades_autonomas_id) REFERENCES comunidades_autonomas(id) ON UPDATE CASCADE ON DELETE CASCADE
);