CREATE TABLE clientes (
  dni VARCHAR(9) PRIMARY KEY,
  nombre VARCHAR(100),
  apellidos VARCHAR(100),
  direccion VARCHAR(100),
  ciudad VARCHAR(50)
);

CREATE TABLE sucursales (
  n_sucursal INT PRIMARY KEY,
  ciudad VARCHAR(50),
  activo BOOLEAN
);

CREATE TABLE cuentas (
  n_cuenta INT PRIMARY KEY,
  saldo FLOAT
);

CREATE TABLE clientes_sucursales_clientes (
  cliente_dni VARCHAR(9),
  cuenta_n_cuenta INT,
  sucursal_n_sucursal INT,
  PRIMARY KEY (cliente_dni, cuenta_n_cuenta, sucursal_n_sucursal),
  FOREIGN KEY (cliente_dni) REFERENCES clientes (dni),
  FOREIGN KEY (cuenta_n_cuenta) REFERENCES cuentas (n_cuenta),
  FOREIGN KEY (sucursal_n_sucursal) REFERENCES sucursales (n_sucursal)
);

CREATE TABLE transacciones (
  n_transaccion INT PRIMARY KEY,
  fecha DATE,
  tipo_operacion VARCHAR(50),
  cantidad FLOAT,
  cuenta_n_cuenta INT,
  FOREIGN KEY (cuenta_n_cuenta) REFERENCES cuentas (n_cuenta)
);
