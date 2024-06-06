CREATE TABLE parques_bomberos (
  cod_parque INT PRIMARY KEY,
  nombre VARCHAR(100),
  direccion VARCHAR(100),
  telefono INT,
  categoria VARCHAR(100)
);

CREATE TABLE coches (
  num_coches INT,
  cod_parque INT,
  marca VARCHAR(100),
  modelo VARCHAR(100),
  num_matricula VARCHAR(7),
  fecha_compra DATE,
  fecha_ult_rev DATE,
  PRIMARY KEY (num_coches, cod_parque),
  FOREIGN KEY (cod_parque) REFERENCES parques_bomberos (cod_parque)
);

CREATE TABLE peticiones_servicios (
  cod_pet_serv INT PRIMARY KEY,
  tipo_serv VARCHAR(100),
  grado_urgenica VARCHAR(100)
);

CREATE TABLE parques_bomberos_peticiones_servicios (
  cod_pet_serv INT,
  cod_parque INT,
  fecha DATE,
  hora TIME,
  PRIMARY KEY (cod_pet_serv, cod_parque),
  FOREIGN KEY (cod_pet_serv) REFERENCES peticiones_servicios (cod_pet_serv),
  FOREIGN KEY (cod_parque) REFERENCES parques_bomberos (cod_parque)
);

CREATE TABLE equipos (
  cod_equipo INT PRIMARY KEY,
  nombre VARCHAR(100)
);

CREATE TABLE peticiones_servicios_equipos (
  cod_pet_serv INT,
  cod_equipo INT,
  PRIMARY KEY (cod_pet_serv, cod_equipo),
  FOREIGN KEY (cod_pet_serv) REFERENCES peticiones_servicios (cod_pet_serv),
  FOREIGN KEY (cod_equipo) REFERENCES equipos (cod_equipo)
);

CREATE TABLE bomberos (
  cod_bombero INT PRIMARY KEY,
  nombre VARCHAR(100),
  apellidos VARCHAR(100),
  fecha_nac DATE,
  dni VARCHAR(9),
  direccion VARCHAR(100),
  telefono INT
);

CREATE TABLE turnos (
  cod_turno INT PRIMARY KEY,
  descripcion VARCHAR(500)
);

CREATE TABLE periodos (
  fecha_inicio DATE,
  fecha_fin DATE,
  PRIMARY KEY (fecha_inicio, fecha_fin)
);

CREATE TABLE bomberos_turnos_periodos (
  cod_bombero INT,
  cod_turno INT,
  fecha_inicio DATE,
  fecha_fin DATE,
  PRIMARY KEY (cod_bombero, cod_turno, fecha_inicio, fecha_fin),
  FOREIGN KEY (cod_bombero) REFERENCES bomberos (cod_bombero),
  FOREIGN KEY (cod_turno) REFERENCES turnos (cod_turno),
  FOREIGN KEY (fecha_inicio, fecha_fin) REFERENCES periodos (fecha_inicio, fecha_fin)
);

CREATE TABLE bomberos_parques_bomberos (
  cod_bombero INT,
  cod_parque INT,
  PRIMARY KEY (cod_bombero, cod_parque),
  FOREIGN KEY (cod_bombero) REFERENCES bomberos (cod_bombero),
  FOREIGN KEY (cod_parque) REFERENCES parques_bomberos (cod_parque)
);

CREATE TABLE bomberos_equipos (
  cod_bombero INT,
  cod_equipo INT,
  puesto VARCHAR(50),
  PRIMARY KEY (cod_bombero, cod_equipo),
  FOREIGN KEY (cod_bombero) REFERENCES bomberos (cod_bombero),
  FOREIGN KEY (cod_equipo) REFERENCES equipos (cod_equipo)
);
