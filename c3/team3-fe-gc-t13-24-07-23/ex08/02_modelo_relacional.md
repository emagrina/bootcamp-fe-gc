**cargos** (**<u>código_cargo</u>** int PK, nombre varchar(30) funciones varchar(30) )

**pisos** (**<u>puerta</u>** PK varchar(10),DNI varchar(10), nombre varchar(20), apellidos varchar(20), dirección varchar(40), código postal int, localidad varchar(20))

**anotaciones** (**<u>codigo_anotacion</u>** int PK, fecha date, importe int)

**ingreso_recibos**(mes date, pagado boolean)

**detalle_recibos**(**<u>numero_linea</u>** int PK, concepto varchar(20), importe int)

**ingresos_extra**(concepto varchar(100))

**gastos_fijos** (fecha_inicio date, fecha_fin date, consumo int)

**tipo_gastos_fijos** (**<u>codigo_tipo</u>** int PK, nombre varchar(20), descripcion varchar(100))

**gastos_variables** (fecha_factura date, concepto varchar(100), numero_factura int)

**piso_cargo** (puerta varchar(10) FK,codigo_cargo int FK )

**piso_detalle_recibo** (puerta varchar(10) FK, numero_linea int FK)

**anotacion_tipo_gasto_fijo** (codigo_tipo_gasto int FK, codigo anotacion int FK)
