CREATE DATABASE IF NOT EXISTS ex02;

USE ex02;

CREATE TABLE piezas (
	codigo INT AUTO_INCREMENT PRIMARY KEY,
	nombre NVARCHAR(100)
);

CREATE TABLE proveedores (
	id CHAR(4) PRIMARY KEY,
	nombre NVARCHAR(100)
);

CREATE TABLE suministra (
	codigo_pieza INT,
	id_proveedor CHAR(4),
	precio INT,
	PRIMARY KEY (codigo_pieza, id_proveedor),
	FOREIGN KEY (codigo_pieza) REFERENCES piezas(codigo) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (id_proveedor) REFERENCES proveedores(id) ON UPDATE CASCADE ON DELETE CASCADE
);