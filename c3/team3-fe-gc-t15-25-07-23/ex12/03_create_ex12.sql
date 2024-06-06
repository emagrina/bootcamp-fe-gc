CREATE DATABASE IF NOT EXISTS ex12;

USE ex12;

CREATE TABLE profesores (
    dni VARCHAR(9) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido1 NVARCHAR(100) NOT NULL,
    apellido2 NVARCHAR(100),
    direccion NVARCHAR(200) NOT NULL,
    titulo NVARCHAR(100) NOT NULL,
    gana FLOAT NOT NULL CHECK (gana >= 0)
);

CREATE TABLE cursos (
    cod_curso INT PRIMARY KEY,
    nombre_curso NVARCHAR(100) UNIQUE,
    dni_profesor VARCHAR(9),
    maximo_alumnos INT,
    fecha_inicio DATE,
    fecha_fin DATE,
    nom_horas INT NOT NULL CHECK (nom_horas > 0),
    FOREIGN KEY (dni_profesor) REFERENCES profesores(dni) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE alumnos (
    dni VARCHAR(9) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL,
    apellido1 NVARCHAR(100) NOT NULL,
    apellido2 NVARCHAR(100),
    direccion NVARCHAR(200) NOT NULL,
    sexo CHAR(1) CHECK (sexo IN ('H', 'M')),
    fecha_nacimiento DATE NOT NULL,
    cod_curso INT,
    FOREIGN KEY (cod_curso) REFERENCES cursos(cod_curso) ON UPDATE CASCADE ON DELETE CASCADE
);