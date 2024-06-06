CREATE DATABASE IF NOT EXISTS ex17;
USE ex17;

CREATE TABLE horarios (
    dia_semana DATE,
    hora TIME,
    codigo INT PRIMARY KEY
);

CREATE TABLE aulas (
    numero INT PRIMARY KEY,
    codigo INT,
    metros_cuadrados INT
);

CREATE TABLE asignaturas (
    codigo_interno_centro INT PRIMARY KEY,
    nombre VARCHAR(255),
    codigo_europeo INT,
    curso_ciclo VARCHAR(255),
    codigo_interno_curso INT,
    numero_aula INT,
    FOREIGN KEY (numero_aula) REFERENCES aulas(numero) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE horarios_asignaturas (
    codigo_horario INT,
    codigo_interno_centro INT,
    FOREIGN KEY (codigo_horario) REFERENCES horarios(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_interno_centro) REFERENCES asignaturas(codigo_interno_centro) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE aulas_asignaturas (
    numero_aula INT,
    codigo_interno_centro INT,
    FOREIGN KEY (numero_aula) REFERENCES aulas(numero) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_interno_centro) REFERENCES asignaturas(codigo_interno_centro) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE asignaturas_requeridas (
    codigo_interno_centro INT,
    asignatura_requerida VARCHAR(255),
    FOREIGN KEY (codigo_interno_centro) REFERENCES asignaturas(codigo_interno_centro) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE profesores (
    codigo_interno_profesor INT PRIMARY KEY,
    nombre VARCHAR(255),
    telefono INT,
    email VARCHAR(255),
    dni VARCHAR(255),
    numero_seguridad_social VARCHAR(255),
    antiguedad_impartiendo_asignatura DATE,
    anos_antiguedad_tutor DATE,
    inicio_de_enseñamiento DATE,
    cese_de_enseñamiento DATE
);

CREATE TABLE profesores_asignaturas (
    codigo_interno_profesor INT,
    codigo_interno_centro INT,
    FOREIGN KEY (codigo_interno_profesor) REFERENCES profesores(codigo_interno_profesor) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_interno_centro) REFERENCES asignaturas(codigo_interno_centro) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE ciclos (
    codigo_interno_curso INT PRIMARY KEY,
    nombre VARCHAR(255),
    tipo_de_grado VARCHAR(255),
    codigo_europeo INT,
    curso VARCHAR(255)
);

CREATE TABLE profesores_ciclos (
    codigo_interno_profesor INT,
    codigo_interno_curso INT,
    FOREIGN KEY (codigo_interno_profesor) REFERENCES profesores(codigo_interno_profesor) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_interno_curso) REFERENCES ciclos(codigo_interno_curso) ON UPDATE CASCADE ON DELETE CASCADE
);

