**fondos**(**<u>titulo</u>** PK: _varchar(100)_, **<u>autor</u>** PK: _varchar(50)_, cantidad: _int_)

**libros**(**<u>signatura</u>** PK: _int_, disponible: _boolean_, _<u>fondos_titulo</u>_ FK: _varchar(100)_, _<u>autor</u>_ FK: _varchar(50)_)

**prestamos**(**<u>n_prestamo</u>** PK: _int_, fecha_prest: _date_, tipo: _varchar(50)_, _<u>libros_signatura</u>_ FK: _int_)

**prestamos_s**(**<u>prestamos_n_prestamo</u>** PK FK: _int_)

**prestamos_e**(**<u>prestamos_n_prestamo</u>** PK FK: _int_, fecha_devol: _date_)

**socios**(**<u>n_socio</u>** PK: _int_, nombre: _varchar(50)_, apellidos: _varchar(100)_, telefono: _int_, fecha_cad: _date_)

**sanciones**(**<u>n_dias</u>** PK: _int_)

**prestamos_socios**(**<u>prestamos_n_prestamo</u>** PK FK: _int_,**<u>socios_n_socio</u>** PK FK: _int_)

**socios_sanciones**(**<u>socios_n_socio</u>** PK FK: _int_, **<u>sanciones_n_dias</u>** PK FK: _int_)