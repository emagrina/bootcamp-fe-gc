CREATE TABLE fondos (
  titulo VARCHAR(100),
  autor VARCHAR(50),
  cantidad INT,
  PRIMARY KEY (titulo, autor)
);

CREATE TABLE libros (
  signatura INT PRIMARY KEY,
  disponible BOOLEAN,
  fondos_titulo VARCHAR(100),
  autor VARCHAR(50),
  FOREIGN KEY (fondos_titulo, autor) REFERENCES fondos (titulo, autor)
);

CREATE TABLE prestamos (
  n_prestamo INT PRIMARY KEY,
  fecha_prest DATE,
  tipo VARCHAR(50),
  libros_signatura INT,
  FOREIGN KEY (libros_signatura) REFERENCES libros (signatura)
);

CREATE TABLE prestamos_s (
  prestamos_n_prestamo INT PRIMARY KEY,
  FOREIGN KEY (prestamos_n_prestamo) REFERENCES prestamos (n_prestamo)
);

CREATE TABLE prestamos_e (
  prestamos_n_prestamo INT PRIMARY KEY,
  fecha_devol DATE,
  FOREIGN KEY (prestamos_n_prestamo) REFERENCES prestamos (n_prestamo)
);

CREATE TABLE socios (
  n_socio INT PRIMARY KEY,
  nombre VARCHAR(50),
  apellidos VARCHAR(100),
  telefono INT,
  fecha_cad DATE
);

CREATE TABLE sanciones (
  n_dias INT PRIMARY KEY
);

CREATE TABLE prestamos_socios (
  prestamos_n_prestamo INT,
  socios_n_socio INT,
  PRIMARY KEY (prestamos_n_prestamo, socios_n_socio),
  FOREIGN KEY (prestamos_n_prestamo) REFERENCES prestamos (n_prestamo),
  FOREIGN KEY (socios_n_socio) REFERENCES socios (n_socio)
);

CREATE TABLE socios_sanciones (
  socios_n_socio INT,
  sanciones_n_dias INT,
  PRIMARY KEY (socios_n_socio, sanciones_n_dias),
  FOREIGN KEY (socios_n_socio) REFERENCES socios (n_socio),
  FOREIGN KEY (sanciones_n_dias) REFERENCES sanciones (n_dias)
);
