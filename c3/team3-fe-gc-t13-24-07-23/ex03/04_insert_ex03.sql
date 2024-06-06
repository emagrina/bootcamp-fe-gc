-- Insertar datos en la tabla clientes
INSERT INTO clientes VALUES ('12345678A', 'Juan', 'Perez', 'Calle Primera, 1', 'Madrid');
INSERT INTO clientes VALUES ('98765432B', 'Ana', 'Gonzalez', 'Avenida Norte, 45', 'Barcelona');

-- Insertar datos en la tabla sucursales
INSERT INTO sucursales VALUES (1, 'Madrid', true);
INSERT INTO sucursales VALUES (2, 'Barcelona', true);

-- Insertar datos en la tabla cuentas
INSERT INTO cuentas VALUES (1, 5000.00);
INSERT INTO cuentas VALUES (2, 3000.00);

-- Insertar datos en la tabla clientes_sucursales_clientes
INSERT INTO clientes_sucursales_clientes VALUES ('12345678A', 1, 1);
INSERT INTO clientes_sucursales_clientes VALUES ('98765432B', 2, 2);

-- Insertar datos en la tabla transacciones
INSERT INTO transacciones VALUES (1, '2023-08-01', 'Depósito', 500.00, 1);
INSERT INTO transacciones VALUES (2, '2023-08-02', 'Retiro', 300.00, 2);
