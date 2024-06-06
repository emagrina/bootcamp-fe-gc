CREATE TABLE arrendatarios (
  cif_nif_arrendatario VARCHAR(30) PRIMARY KEY,
  nombre_fiscal VARCHAR(100),
  nombre_firmante VARCHAR(100),
  direccion VARCHAR(200),
  codigo_postal INT,
  localidad VARCHAR(50),
  provincia VARCHAR(50),
  telefono_fijo INT,
  telefono_movil INT,
  fax INT,
  actividad VARCHAR(200)
);

CREATE TABLE naves (
  cod_nave INT PRIMARY KEY,
  poligono VARCHAR(200),
  calle VARCHAR(100),
  numero INT,
  localidad VARCHAR(50),
  codigo_postal INT,
  provincia VARCHAR(50),
  telefono INT,
  caracteristicas VARCHAR(300),
  foto VARCHAR(100),
  datos_escritura VARCHAR(100),
  alquilada BOOLEAN,
  gastos_comunidad FLOAT
);

CREATE TABLE recibos (
  numero_recibos INT PRIMARY KEY,
  importe_total FLOAT,
  importe_iva FLOAT,
  pagado BOOLEAN,
  fecha DATE
);

CREATE TABLE arrendatarios_naves (
  arrendatarios_cif_nif_arrendatario VARCHAR(30),
  naves_cod_nave INT,
  numero_cuenta INT,
  dias_pago INT,
  fecha_alquiler DATE,
  fecha_fin_alquiler DATE,
  importe_alquiler FLOAT,
  PRIMARY KEY (arrendatarios_cif_nif_arrendatario, naves_cod_nave),
  FOREIGN KEY (arrendatarios_cif_nif_arrendatario) REFERENCES arrendatarios (cif_nif_arrendatario),
  FOREIGN KEY (naves_cod_nave) REFERENCES naves (cod_nave)
);

CREATE TABLE naves_recibos (
  naves_cod_nave INT,
  recibos_numero_recibos INT,
  PRIMARY KEY (naves_cod_nave, recibos_numero_recibos),
  FOREIGN KEY (naves_cod_nave) REFERENCES naves (cod_nave),
  FOREIGN KEY (recibos_numero_recibos) REFERENCES recibos (numero_recibos)
);
