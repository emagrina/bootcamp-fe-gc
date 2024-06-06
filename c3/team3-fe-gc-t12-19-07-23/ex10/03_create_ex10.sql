CREATE DATABASE IF NOT EXISTS ex10;

USE ex10;

CREATE TABLE jugadores (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    fecha_nacimiento DATE,
    nacionalidad VARCHAR(50),
    posicion VARCHAR(50),
    dorsal INT
);

CREATE TABLE temporadas (
    cod_temp INT PRIMARY KEY,
    fecha_inicio DATE,
    fecha_final DATE
);

CREATE TABLE partidos (
    id INT PRIMARY KEY,
    fecha DATE,
    estadio VARCHAR(100),
    id_jugador INT,
    cod_temp INT,
    FOREIGN KEY (id_jugador) REFERENCES jugadores(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (cod_temp) REFERENCES temporadas(cod_temp) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE equipos_locales (
    cod_local INT PRIMARY KEY,
    id_partido INT,
    FOREIGN KEY (id_partido) REFERENCES partidos(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE equipos_visitantes (
    cod_visitante INT PRIMARY KEY,
    id_partido INT,
    FOREIGN KEY (id_partido) REFERENCES partidos(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE estadisticas (
    cod_estadisticas INT PRIMARY KEY,
    goles_anotados INT,
    asistencias INT,
    targ_amarillas INT,
    targ_rojas INT,
    id_partido INT,
    id_jugador INT,
    FOREIGN KEY (id_partido) REFERENCES partidos(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_jugador) REFERENCES jugadores(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE equipos (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    ciudad VARCHAR(100),
    fundacion DATE,
    estadio VARCHAR(100),
    entrenador VARCHAR(100),
    id_jugador INT,
    FOREIGN KEY (id_jugador) REFERENCES jugadores(id) ON UPDATE CASCADE ON DELETE CASCADE
);
