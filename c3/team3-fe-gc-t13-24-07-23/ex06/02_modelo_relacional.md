**clientes**(**<u>cod_cliente</u>** PK: _int_)

**pedidos**(**<u>cod_pedido</u>** PK: _int_, fecha_pedido: _date_, _<u>clientes_cod_cliente</u>_ FK: _int_)

**productos**(**<u>cod_producto</u>** PK: _int_, cantidad: _int_)

**proveedores**(**<u>cod_proveedor</u>** PK: _int_)

**proveedores_productos**(**<u>productos_cod_producto</u>** PK FK: _int_, **<u>proveedores_cod_proveedor</u>** PK FK: _int_, unidades: _int_, fecha_encargo: _date_)

**detalle_pedido**(**<u>pedidos_cod_pedido</u>** PK FK: _int_, **<u>productos_cod_producto</u>** PK FK: _int_, num_unidades: _int_)