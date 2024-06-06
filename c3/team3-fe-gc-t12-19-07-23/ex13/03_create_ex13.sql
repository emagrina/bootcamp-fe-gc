CREATE DATABASE IF NOT EXISTS ex13;

USE ex13;

CREATE TABLE empleados (
    dni INT PRIMARY KEY,
    nombre VARCHAR(50),
    apellidos VARCHAR(50),
    numero_seguridad_social VARCHAR(20),
    telefono_fijo VARCHAR(15),
    telefono_movil VARCHAR(15),
    tipo_empleado VARCHAR(50)
);

CREATE TABLE cocineros (
    dni INT PRIMARY KEY,
    anos_servicio INT,
    dni_empleado INT,
    FOREIGN KEY (dni_empleado) REFERENCES empleados(dni) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE pinches (
    dni INT PRIMARY KEY,
    fecha_nacimiento DATE,
    dni_cocinero INT,
    dni_empleado INT,
    FOREIGN KEY (dni_cocinero) REFERENCES cocineros(dni) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (dni_empleado) REFERENCES empleados(dni) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE platos (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    precio DECIMAL(10, 2),
    tipo_plato VARCHAR(50)
);

CREATE TABLE ingredientes (
    id INT PRIMARY KEY,
    nombre VARCHAR(100)
);

CREATE TABLE almacenes (
    id INT PRIMARY KEY,
    nombre VARCHAR(100),
    descripcion VARCHAR(500)
);

CREATE TABLE estantes (
    id INT PRIMARY KEY,
    letras VARCHAR(10),
    tamano VARCHAR(50),
    id_almacen INT,
    FOREIGN KEY (id_almacen) REFERENCES almacenes(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE cocineros_platos (
    dni_cocinero INT,
    id_plato INT,
    PRIMARY KEY (dni_cocinero, id_plato),
    FOREIGN KEY (dni_cocinero) REFERENCES cocineros(dni) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_plato) REFERENCES platos(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE platos_ingredientes (
    id_plato INT,
    id_ingrediente INT,
    cantidad INT,
    PRIMARY KEY (id_plato, id_ingrediente),
    FOREIGN KEY (id_plato) REFERENCES platos(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_ingrediente) REFERENCES ingredientes(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE ingredientes_estantes (
    id_ingrediente INT,
    id_estante INT,
    cantidad INT,
    PRIMARY KEY (id_ingrediente, id_estante),
    FOREIGN KEY (id_ingrediente) REFERENCES ingredientes(id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_estante) REFERENCES estantes(id) ON DELETE CASCADE ON UPDATE CASCADE
);