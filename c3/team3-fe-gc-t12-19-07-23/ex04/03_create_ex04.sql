CREATE DATABASE IF NOT EXISTS ex04;

USE ex04;

CREATE TABLE guerra (
  id INT PRIMARY KEY,
  nombre VARCHAR(255),
  ano_inicio INT,
  ano_fin INT
);

CREATE TABLE pais (
  id INT PRIMARY KEY,
  nombre VARCHAR(255),
  ano_independencia_inicio INT,
  ano_independencia_fin INT
);

CREATE TABLE bando (id INT PRIMARY KEY, nombre VARCHAR(255));

CREATE TABLE participacion (
  id INT PRIMARY KEY,
  id_guerra INT,
  id_pais INT,
  ano_entrada INT,
  ano_salida INT,
  ganador BOOLEAN,
  FOREIGN KEY (id_guerra) REFERENCES guerra(id) ON UPDATE CASCADE ON DELETE CASCADE,
  FOREIGN KEY (id_pais) REFERENCES pais(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE afiliacion (
  id INT PRIMARY KEY,
  id_bando INT,
  id_pais INT,
  FOREIGN KEY (id_bando) REFERENCES bando(id) ON UPDATE CASCADE ON DELETE CASCADE,
  FOREIGN KEY (id_pais) REFERENCES pais(id) ON UPDATE CASCADE ON DELETE CASCADE
);