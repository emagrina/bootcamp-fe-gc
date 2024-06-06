CREATE DATABASE IF NOT EXISTS ex04;

USE ex04;

CREATE TABLE departamentos (
    codigo INT PRIMARY KEY,
    nombre NVARCHAR(100),
    presupuesto INT
);

CREATE TABLE empleados (
    dni VARCHAR(8) PRIMARY KEY,
    nombre NVARCHAR(100),
    apellidos NVARCHAR(255),
    departamento INT,
    FOREIGN KEY (departamento) REFERENCES departamentos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);