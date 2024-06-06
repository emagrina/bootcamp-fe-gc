INSERT INTO clientes (dni, telefono_fijo, movil, nombre, apellidos, codigo_personal)
VALUES
('1111111111', '123456789', '987654321', 'Juan', 'Pérez', 'CP123'),
('2222222222', '987654321', '111111111', 'María', 'Gómez', 'CP456'),
('3333333333', '555555555', '222222222', 'Pedro', 'Rodríguez', 'CP789'),
('4444444444', '666666666', '333333333', 'Ana', 'Sánchez', 'CP123'),
('5555555555', '777777777', '444444444', 'Carlos', 'López', 'CP456'),
('6666666666', '888888888', '555555555', 'Laura', 'García', 'CP789'),
('7777777777', '999999999', '666666666', 'Fernando', 'Martínez', 'CP123'),
('8888888888', '000000000', '777777777', 'Elena', 'Ramírez', 'CP456'),
('9999999999', '111111111', '888888888', 'José', 'Gómez', 'CP789'),
('1234567890', '222222222', '999999999', 'Sofía', 'Pérez', 'CP123');

INSERT INTO trabajadores (dni, telefono_fijo, movil, nombre, apellidos, codigo_personal)
VALUES
('1111111111', '123456789', '987654321', 'Juan', 'Pérez', 'CP123'),
('2222222222', '987654321', '111111111', 'María', 'Gómez', 'CP456'),
('3333333333', '555555555', '222222222', 'Pedro', 'Rodríguez', 'CP789'),
('4444444444', '666666666', '333333333', 'Ana', 'Sánchez', 'CP123'),
('5555555555', '777777777', '444444444', 'Carlos', 'López', 'CP456'),
('6666666666', '888888888', '555555555', 'Laura', 'García', 'CP789'),
('7777777777', '999999999', '666666666', 'Fernando', 'Martínez', 'CP123'),
('8888888888', '000000000', '777777777', 'Elena', 'Ramírez', 'CP456'),
('9999999999', '111111111', '888888888', 'José', 'Gómez', 'CP789'),
('1234567890', '222222222', '999999999', 'Sofía', 'Pérez', 'CP123');

INSERT INTO compras (Cod_compra, Fecha, Valor)
VALUES
(1, '2023-07-01', 1000.50),
(2, '2023-07-05', 750.25),
(3, '2023-07-10', 1230.00),
(4, '2023-07-15', 800.75),
(5, '2023-07-20', 900.00),
(6, '2023-07-25', 1500.00),
(7, '2023-07-30', 2000.25),
(8, '2023-08-01', 1750.50),
(9, '2023-08-05', 2300.00),
(10, '2023-08-10', 1200.75);

INSERT INTO alquileres (num_alquiler, fecha, agente_empresa, dni_cliente, dni_trabajador)
VALUES
(1, '2023-07-01', 'Empresa A', '1111111111', '1111111111'),
(2, '2023-07-05', 'Empresa B', '2222222222', '2222222222'),
(3, '2023-07-10', 'Empresa C', '3333333333', '3333333333'),
(4, '2023-07-15', 'Empresa A', '4444444444', '4444444444'),
(5, '2023-07-20', 'Empresa B', '5555555555', '5555555555'),
(6, '2023-07-25', 'Empresa C', '6666666666', '6666666666'),
(7, '2023-07-30', 'Empresa A', '7777777777', '7777777777'),
(8, '2023-08-01', 'Empresa B', '8888888888', '8888888888'),
(9, '2023-08-05', 'Empresa C', '9999999999', '9999999999'),
(10, '2023-08-10', 'Empresa A', '1234567890', '1234567890');

INSERT INTO inmuebles (id_moble, metros, descripcion, dirección)
VALUES
(1, 80.5, 'Local comercial en centro comercial', 'Calle Principal 123'),
(2, 90.0, 'Piso en zona residencial', 'Avenida Secundaria 456'),
(3, 50.75, 'Garaje en edificio de apartamentos', 'Calle Peatonal 789'),
(4, 100.0, 'Local en esquina con vitrina', 'Calle Comercial 101'),
(5, 75.25, 'Piso con terraza y vistas al mar', 'Avenida del Mar 202'),
(6, 60.0, 'Garaje en complejo de oficinas', 'Calle de los Negocios 303'),
(7, 120.0, 'Local en zona de alto tráfico', 'Avenida Principal 404'),
(8, 85.5, 'Piso con balcón y jardín comunitario', 'Calle Residencial 505'),
(9, 70.25, 'Garaje en centro comercial', 'Avenida Comercial 606'),
(10, 95.0, 'Local con almacén y baño', 'Calle del Mercado 707');


INSERT INTO pagos (id_pago, fecha, valor, num_alquiler)
VALUES
(1, '2023-07-01', 100.50, 1),
(2, '2023-07-05', 75.25, 2),
(3, '2023-07-10', 123.00, 3),
(4, '2023-07-15', 80.75, 4),
(5, '2023-07-20', 90.00, 5),
(6, '2023-07-25', 150.00, 6),
(7, '2023-07-30', 200.25, 7),
(8, '2023-08-01', 175.50, 8),
(9, '2023-08-05', 230.00, 9),
(10, '2023-08-10', 120.75, 10);

INSERT INTO locales (id_local, servicio)
VALUES
(1, 'WiFi gratuito'),
(2, 'Aire acondicionado'),
(3, 'Alarma de seguridad'),
(4, 'Estacionamiento privado'),
(5, 'Cocina equipada'),
(6, 'Baños modernos'),
(7, 'Sistema de iluminación LED'),
(8, 'Área de recepción'),
(9, 'Vidrieras amplias'),
(10, 'Acceso para personas con discapacidad');

INSERT INTO pisos (id_piso, bloque)
VALUES
(1, 'Bloque A'),
(2, 'Bloque B'),
(3, 'Bloque C'),
(4, 'Bloque A'),
(5, 'Bloque B'),
(6, 'Bloque C'),
(7, 'Bloque A'),
(8, 'Bloque B'),
(9, 'Bloque C'),
(10, 'Bloque A');

INSERT INTO garajes (num_garaje, planta)
VALUES
(1, 1),
(2, 2),
(3, 1),
(4, 2),
(5, 3),
(6, 1),
(7, 2),
(8, 1),
(9, 3),
(10, 2);