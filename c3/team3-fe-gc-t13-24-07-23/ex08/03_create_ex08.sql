CREATE TABLE cargos (
  codigo_cargo INT PRIMARY KEY,
  nombre VARCHAR(30),
  funciones VARCHAR(30)
);

CREATE TABLE pisos (
  puerta VARCHAR(10) PRIMARY KEY,
  DNI VARCHAR(10),
  nombre VARCHAR(20),
  apellidos VARCHAR(20),
  direccion VARCHAR(40),
  codigo_postal INT,
  localidad VARCHAR(20)
);

CREATE TABLE anotaciones (
  codigo_anotacion INT PRIMARY KEY,
  fecha DATE,
  importe INT
);

CREATE TABLE ingreso_recibos (
  codigo_anotacion INT PRIMARY KEY,
  mes DATE,
  pagado BOOLEAN,
  puerta VARCHAR(10),
  FOREIGN KEY (codigo_anotacion) REFERENCES anotaciones (codigo_anotacion),
  FOREIGN KEY (puerta) REFERENCES pisos (puerta)
);

CREATE TABLE detalle_recibos (
  numero_linea INT PRIMARY KEY,
  concepto VARCHAR(20),
  importe INT
);

CREATE TABLE ingresos_extra (
  codigo_anotacion INT PRIMARY KEY,
  concepto VARCHAR(100),
  FOREIGN KEY (codigo_anotacion) REFERENCES anotaciones (codigo_anotacion)
);	

CREATE TABLE gastos_fijos (
  codigo_anotacion INT PRIMARY KEY,
  fecha_inicio DATE,
  fecha_fin DATE,
  consumo INT,
  FOREIGN KEY (codigo_anotacion) REFERENCES anotaciones (codigo_anotacion)
);

CREATE TABLE tipo_gastos_fijos (
  codigo_tipo INT PRIMARY KEY,
  nombre VARCHAR(20),
  descripcion VARCHAR(100)
);

CREATE TABLE gastos_variables (
  codigo_anotacion INT PRIMARY KEY,
  fecha_factura DATE,
  concepto VARCHAR(100),
  numero_factura INT,
  FOREIGN KEY (codigo_anotacion) REFERENCES anotaciones (codigo_anotacion)
);

CREATE TABLE piso_cargo (
  puerta VARCHAR(10),
  codigo_cargo INT,
  PRIMARY KEY (puerta, codigo_cargo),
  FOREIGN KEY (puerta) REFERENCES pisos (puerta),
  FOREIGN KEY (codigo_cargo) REFERENCES cargos (codigo_cargo)
);

CREATE TABLE piso_detalle_recibo (
  puerta VARCHAR(10),
  numero_linea INT,
  PRIMARY KEY (puerta, numero_linea),
  FOREIGN KEY (puerta) REFERENCES pisos (puerta),
  FOREIGN KEY (numero_linea) REFERENCES detalle_recibos (numero_linea)
);

CREATE TABLE anotacion_tipo_gasto_fijo (
  codigo_tipo_gasto INT,
  codigo_anotacion INT,
  PRIMARY KEY (codigo_tipo_gasto, codigo_anotacion),
  FOREIGN KEY (codigo_tipo_gasto) REFERENCES tipo_gastos_fijos (codigo_tipo),
  FOREIGN KEY (codigo_anotacion) REFERENCES anotaciones (codigo_anotacion)
);
