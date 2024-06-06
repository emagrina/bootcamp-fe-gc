CREATE DATABASE IF NOT EXISTS ex01;

USE ex01;

CREATE TABLE estaciones (
    identificador INT PRIMARY KEY,
    latitud FLOAT,
    longitud FLOAT,
    altitud FLOAT
);

CREATE TABLE muestras (
    identificador_estacion INT,
    fecha DATE,
    temperatura_minima FLOAT,
    temperatura_maxima FLOAT,
    precipitaciones FLOAT,
    humedad_minima FLOAT,
    humedad_maxima FLOAT,
    velocidad_viento_minima FLOAT,
    velocidad_viento_maxima FLOAT,
    PRIMARY KEY (identificador_estacion, fecha),
    FOREIGN KEY (identificador_estacion) REFERENCES estaciones(identificador) ON UPDATE CASCADE ON DELETE CASCADE
);