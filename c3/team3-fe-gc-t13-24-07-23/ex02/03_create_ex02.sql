CREATE TABLE elementos (
  nombre_elemento VARCHAR(50) PRIMARY KEY,
  peso_atomico FLOAT,
  simbolo VARCHAR(2),
  n_atomico INT
);

CREATE TABLE compuestos (
  nombre_compuesto VARCHAR(50) PRIMARY KEY,
  estado VARCHAR(30)
);

CREATE TABLE elementos_compuestos (
  nombre_compuesto VARCHAR(50),
  nombre_elemento VARCHAR(50),
  proporcion FLOAT,
  PRIMARY KEY (nombre_compuesto, nombre_elemento),
  FOREIGN KEY (nombre_compuesto) REFERENCES compuestos (nombre_compuesto),
  FOREIGN KEY (nombre_elemento) REFERENCES elementos (nombre_elemento)
);

CREATE TABLE gaseosos (
  nombre_compuesto VARCHAR(50) PRIMARY KEY,
  coef_expan FLOAT,
  temp_lic INT,
  FOREIGN KEY (nombre_compuesto) REFERENCES compuestos (nombre_compuesto)
);

CREATE TABLE liquidos (
  nombre_compuesto VARCHAR(50) PRIMARY KEY,
  densidad FLOAT,
  temp_evap INT,
  FOREIGN KEY (nombre_compuesto) REFERENCES compuestos (nombre_compuesto)
);

CREATE TABLE solidos (
  nombre_compuesto VARCHAR(50) PRIMARY KEY,
  color VARCHAR(50),
  olor VARCHAR(50),
  dureza FLOAT,
  FOREIGN KEY (nombre_compuesto) REFERENCES compuestos (nombre_compuesto)
);
