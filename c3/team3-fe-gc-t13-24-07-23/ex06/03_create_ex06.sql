CREATE TABLE clientes (
  cod_cliente INT PRIMARY KEY
);

CREATE TABLE pedidos (
  cod_pedido INT PRIMARY KEY,
  fecha_pedido DATE,
  clientes_cod_cliente INT,
  FOREIGN KEY (clientes_cod_cliente) REFERENCES clientes (cod_cliente)
);

CREATE TABLE productos (
  cod_producto INT PRIMARY KEY,
  cantidad INT
);

CREATE TABLE proveedores (
  cod_proveedor INT PRIMARY KEY
);

CREATE TABLE proveedores_productos (
  productos_cod_producto INT,
  proveedores_cod_proveedor INT,
  unidades INT,
  fecha_encargo DATE,
  PRIMARY KEY (productos_cod_producto, proveedores_cod_proveedor),
  FOREIGN KEY (productos_cod_producto) REFERENCES productos (cod_producto),
  FOREIGN KEY (proveedores_cod_proveedor) REFERENCES proveedores (cod_proveedor)
);

CREATE TABLE detalle_pedido (
  pedidos_cod_pedido INT,
  productos_cod_producto INT,
  num_unidades INT,
  PRIMARY KEY (pedidos_cod_pedido, productos_cod_producto),
  FOREIGN KEY (pedidos_cod_pedido) REFERENCES pedidos (cod_pedido),
  FOREIGN KEY (productos_cod_producto) REFERENCES productos (cod_producto)
);
