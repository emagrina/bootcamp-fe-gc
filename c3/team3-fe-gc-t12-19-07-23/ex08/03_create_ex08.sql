CREATE DATABASE IF NOT EXISTS ex08;

USE ex08;

CREATE TABLE clientes (
    dni VARCHAR(9) PRIMARY KEY,
    nombre VARCHAR(50),
    apellidos VARCHAR(50),
    direccion VARCHAR(100),
    telefono VARCHAR(15),
    numero_tarjeta VARCHAR(20)
);

CREATE TABLE reservas (
    id INT PRIMARY KEY,
    dni_cliente VARCHAR(9),
    numero_plazas INT,
    fecha_reserva DATE,
    FOREIGN KEY (dni_cliente) REFERENCES clientes(dni) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE tarjetas_embarques (
    id_tarjeta INT PRIMARY KEY,
    dni_cliente VARCHAR(9),
    id_reserva INT,
    fila INT,
    columna INT,
    planta INT,
    FOREIGN KEY (dni_cliente) REFERENCES clientes(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_reserva) REFERENCES reservas(id) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE aeropuertos (
    codigo VARCHAR(5) PRIMARY KEY,
    nombre VARCHAR(50),
    localidad VARCHAR(50),
    pais VARCHAR(50)
);

CREATE TABLE aviones (
    codigo VARCHAR(6) PRIMARY KEY,
    numero_plazas INT
);

CREATE TABLE vuelos (
    codigo VARCHAR(6) PRIMARY KEY,
    fecha_salida DATE,
    hora_salida TIME,
    fecha_llegada DATE,
    hora_llegada TIME,
    codigo_aeropuerto_salida VARCHAR(5),
    codigo_aeropuerto_llegada VARCHAR(5),
    codigo_avion VARCHAR(6),
    FOREIGN KEY (codigo_aeropuerto_salida) REFERENCES aeropuertos(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_aeropuerto_llegada) REFERENCES aeropuertos(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_avion) REFERENCES aviones(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE reservas_vuelos (
    id_reserva INT,
    codigo_vuelo VARCHAR(6),
    PRIMARY KEY (id_reserva, codigo_vuelo),
    FOREIGN KEY (id_reserva) REFERENCES reservas(id) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (codigo_vuelo) REFERENCES vuelos(codigo) ON UPDATE CASCADE ON DELETE CASCADE
);