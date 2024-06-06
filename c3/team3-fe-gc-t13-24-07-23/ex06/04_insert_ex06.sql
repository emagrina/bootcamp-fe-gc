-- Insertar datos en la tabla clientes
INSERT INTO clientes VALUES (1);
INSERT INTO clientes VALUES (2);
INSERT INTO clientes VALUES (3);

-- Insertar datos en la tabla pedidos
INSERT INTO pedidos VALUES (1, '2023-08-01', 1);
INSERT INTO pedidos VALUES (2, '2023-08-02', 1);
INSERT INTO pedidos VALUES (3, '2023-08-03', 2);

-- Insertar datos en la tabla productos
INSERT INTO productos VALUES (1, 100);
INSERT INTO productos VALUES (2, 200);
INSERT INTO productos VALUES (3, 150);

-- Insertar datos en la tabla proveedores
INSERT INTO proveedores VALUES (1);
INSERT INTO proveedores VALUES (2);
INSERT INTO proveedores VALUES (3);

-- Insertar datos en la tabla proveedores_productos
INSERT INTO proveedores_productos VALUES (1, 1, 50, '2023-07-01');
INSERT INTO proveedores_productos VALUES (2, 1, 100, '2023-07-02');
INSERT INTO proveedores_productos VALUES (2, 2, 150, '2023-07-03');

-- Insertar datos en la tabla detalle_pedido
INSERT INTO detalle_pedido VALUES (1, 1, 10);
INSERT INTO detalle_pedido VALUES (1, 2, 20);
INSERT INTO detalle_pedido VALUES (2, 1, 15);
