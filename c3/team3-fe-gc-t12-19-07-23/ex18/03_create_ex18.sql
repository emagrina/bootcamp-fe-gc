CREATE DATABASE IF NOT EXISTS ex18;
USE ex18;

CREATE TABLE clientes (
    dni VARCHAR(10) PRIMARY KEY,
    telefono_fijo VARCHAR(15),
    movil VARCHAR(15),
    nombre VARCHAR(50),
    apellidos VARCHAR(50),
    codigo_personal VARCHAR(20)
);

CREATE TABLE trabajadores (
    dni VARCHAR(10) PRIMARY KEY,
    telefono_fijo VARCHAR(15),
    movil VARCHAR(15),
    nombre VARCHAR(50),
    apellidos VARCHAR(50),
    codigo_personal VARCHAR(20)
);

CREATE TABLE compras (
    Cod_compra INT PRIMARY KEY,
    Fecha DATE,
    Valor DECIMAL(10, 2)
);

CREATE TABLE alquileres (
    num_alquiler INT PRIMARY KEY,
    fecha DATE,
    agente_empresa VARCHAR(100),
    dni_cliente VARCHAR(10),
    dni_trabajador VARCHAR(10),
    FOREIGN KEY (dni_cliente) REFERENCES clientes(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (dni_trabajador) REFERENCES trabajadores(dni) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE inmuebles (
    id_moble INT PRIMARY KEY,
    metros DECIMAL(6, 2),
    descripcion VARCHAR(100),
    dirección VARCHAR(100)
);

CREATE TABLE pagos (
    id_pago INT PRIMARY KEY,
    fecha DATE,
    valor DECIMAL(10, 2),
    num_alquiler INT,
    FOREIGN KEY (num_alquiler) REFERENCES alquileres(num_alquiler) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE locales (
    id_local INT PRIMARY KEY,
    servicio VARCHAR(100),
    FOREIGN KEY (id_local) REFERENCES inmuebles(id_moble) ON UPDATE CASCADE ON DELETE CASCADE
);


CREATE TABLE pisos (
    id_piso INT PRIMARY KEY,
    bloque VARCHAR(50),
    FOREIGN KEY (id_piso) REFERENCES inmuebles(id_moble) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE garajes (
    num_garaje INT PRIMARY KEY,
    planta INT,
    FOREIGN KEY (num_garaje) REFERENCES inmuebles(id_moble) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE clientes_compras (
    id INT PRIMARY KEY,
    dni_cliente VARCHAR(10),
    cod_compra INT,
    FOREIGN KEY (dni_cliente) REFERENCES clientes(dni) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (cod_compra) REFERENCES compras(cod_compra) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE alquileres_inmuebles (
    id INT PRIMARY KEY,
    num_alquiler INT,
    id_moble INT,
    FOREIGN KEY (num_alquiler) REFERENCES alquileres(num_alquiler) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_moble) REFERENCES inmuebles(id_moble) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE compras_inmuebles (
    id INT PRIMARY KEY,
    cod_compra INT,
    id_moble INT,
    FOREIGN KEY (cod_compra) REFERENCES compras(Cod_compra) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (id_moble) REFERENCES inmuebles(id_moble) ON UPDATE CASCADE ON DELETE CASCADE
);