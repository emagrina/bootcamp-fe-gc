**clientes**(**<u>dni</u>** PK: _varchar(9)_, nombre: _varchar(100)_, apellidos: _varchar(100)_, direccion: _varchar(100)_, ciudad: _varchar(50)_)

**sucursales**(**<u>n_sucursal</u>** PK : _int_, ciudad: _varchar(50)_, activo: _boolean_)

**cuentas**(**<u>n_cuenta</u>** PK : _int_, saldo: _float_)

**clientes_sucursales_clientes**(**<u>cliente_dni</u>** PK FK: _varchar(9)_, **<u>cuenta_n_cuenta</u>** PK FK: _int_, **<u>sucursal_n_sucursal</u>** PK FK: _int_)

**transacciones**(**<u>n_transaccion</u>** PK : _int_, fecha: _date_, tipo_operacion: _varchar(50)_, cantidad: _float_, _<u>cuenta_n_cuenta</u>_ PK: _int_