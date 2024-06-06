CREATE DATABASE IF NOT EXISTS ex07;
USE ex07;

CREATE TABLE nominas (
    id INT PRIMARY KEY,
    fecha DATE,
    salario FLOAT
);

CREATE TABLE trabajadores (
    dni VARCHAR(20) PRIMARY KEY,
    num_seguridad_social VARCHAR(50),
    codigo INT,
    nombre VARCHAR(100),
    apellidos VARCHAR(100),
    direccion VARCHAR(200),
    telefono VARCHAR(15),
    id_nomina INT,
    FOREIGN KEY (id_nomina) REFERENCES nominas(id)
);

CREATE TABLE departamentos (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(100),
    dni_trabajador VARCHAR(20),
    FOREIGN KEY (dni_trabajador) REFERENCES trabajadores(dni)
);

CREATE TABLE categoria_profesional (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    dni_trabajador VARCHAR(20),
    FOREIGN KEY (dni_trabajador) REFERENCES trabajadores(dni)
);

CREATE TABLE contrato (
    id INT PRIMARY KEY,
    fecha_inicio DATE,
    fecha_final DATE,
    dni_trabajador VARCHAR(20),
    FOREIGN KEY (dni_trabajador) REFERENCES trabajadores(dni)
);
