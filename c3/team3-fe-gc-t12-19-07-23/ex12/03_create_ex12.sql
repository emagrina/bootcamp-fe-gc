CREATE DATABASE IF NOT EXISTS ex12;

USE ex12;

CREATE TABLE empresas (
    cif VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(50),
    direccion VARCHAR(100),
    telefono VARCHAR(13),
    codigo_interno_empresa VARCHAR(50)
);

CREATE TABLE proyectos (
    id INT PRIMARY KEY,
    fecha_inicio DATE,
    fecha_finalizacion DATE,
    fecha_prevista_finalizacion DATE,
    cif_empresa VARCHAR(50),
    FOREIGN KEY (cif_empresa) REFERENCES empresas(cif) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE profesiones (
    codigo_profesion INT PRIMARY KEY,
    nombre VARCHAR(50)
);

CREATE TABLE trabajadores (
    codigo_trabajador INT PRIMARY KEY,
    dni VARCHAR(20),
    nombre VARCHAR(50),
    apellidos VARCHAR(50),
    codigo_profesion INT,
    FOREIGN KEY (codigo_profesion) REFERENCES profesiones(codigo_profesion) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE participaciones (
    codigo_trabajador INT,
    id_proyecto INT,
    horas_trabajadas INT,
    PRIMARY KEY (codigo_trabajador, id_proyecto),
    FOREIGN KEY (codigo_trabajador) REFERENCES trabajadores(codigo_trabajador) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_proyecto) REFERENCES proyectos(id) ON DELETE CASCADE ON UPDATE CASCADE
);