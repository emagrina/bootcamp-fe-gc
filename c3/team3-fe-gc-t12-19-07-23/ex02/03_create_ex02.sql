CREATE DATABASE IF NOT EXISTS ex02;

USE ex02;

CREATE TABLE trabajadores (
    dni VARCHAR(9) PRIMARY KEY,
    cif VARCHAR(10),
    nombre VARCHAR(50),
    telefono INT,
    direccion_empresa VARCHAR(100)
);

CREATE TABLE alumnos (
    dni VARCHAR(9) PRIMARY KEY,
    direccion VARCHAR(100),
    nombre VARCHAR(50),
    telefono INT,
    edad INT
);

CREATE TABLE cursos (
    codigo INT PRIMARY KEY,
    titulo VARCHAR(100),
    programa VARCHAR(100),
    horas_duracion INT
);

CREATE TABLE profesores (
    dni VARCHAR(9) PRIMARY KEY,
    nombre VARCHAR(50),
    apellidos VARCHAR(100),
    direccion VARCHAR(100),
    telefono INT
);

CREATE TABLE trabajadores_alumnos (
    dni_trabajador VARCHAR(9),
    dni_alumno VARCHAR(9),
    PRIMARY KEY (dni_trabajador, dni_alumno),
    FOREIGN KEY (dni_trabajador) REFERENCES trabajadores(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (dni_alumno) REFERENCES alumnos(dni) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE alumnos_cursos (
    dni_alumno VARCHAR(9),
    codigo_curso INT,
    nota FLOAT,
    PRIMARY KEY (dni_alumno, codigo_curso),
    FOREIGN KEY (dni_alumno) REFERENCES alumnos(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_curso) REFERENCES cursos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE cursos_profesores (
    dni_profesor VARCHAR(9),
    codigo_curso INT,
    PRIMARY KEY (dni_profesor, codigo_curso),
    FOREIGN KEY (dni_profesor) REFERENCES profesores(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_curso) REFERENCES cursos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);