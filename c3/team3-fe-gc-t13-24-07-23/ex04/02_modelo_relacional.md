**parques_bomberos**(**<u>cod_parque</u>** PK: _int_, nombre: _varchar(100)_, direccion: _varchar(100)_, telefono: _int_, categoria: _varchar(100)_)

**coches**(**<u>num_coches</u>** PK: _int_, _<u>cod_parque</u>_ PK FK: _int_, marca: _varchar(100)_, modelo: _varchar(100)_, num_matricula _varchar(7)_, fecha_compra: _date_, fecha_ult_rev: _date_)

**peticiones_servicios**(**<u>cod_pet_serv</u>** PK: _int_, tipo_serv: _varchar(100)_, grado_urgenica: _varchar(100)_)

**parques_bomberos_peticiones_servicios**(**<u>cod_pet_serv</u>** PK FK: _int_ **<u>cod_pet_serv</u>** PK FK: _int_, fecha: _date_, hora: _time_)

**equipos**(**<u>cod_equipo</u>** PK: _int_, nombre: _varchar(100)_)

**peticiones_servicios_equipos**(**<u>cod_pet_serv</u>** PK FK: _int_, **<u>cod_equipo</u>** PK FK: _int_)

**bomberos**(**<u>cod_bombero</u>** PK: _int_, nombre: _varchar(100)_, apellidos: _varchar(100)_, fecha_nac: _date_, dni: _varchar(9)_, direccion: _varchar(100)_, telefono: _int_)

**turnos**(**<u>cod_turno</u>** PK: _int_, descripcion: _varchar(500)_)

**periodos**(**<u>fecha_inicio</u>** PK: _date_, **<u>fecha_fin</u>** PK: _date_)

**bomberos_turnos_periodos**(**<u>cod_bombero</u>** PK FK: _int_, **<u>cod_turno</u>** PK FK: _int_, **<u>fecha_inicio</u>** PK FK: _date_, **<u>fecha_fin</u>** PK FK: _date_)

**bomberos_parques_bomberos**(**<u>cod_bombero</u>** PK FK: _int_, **<u>cod_parque</u>** PK FK: _int_)

**bomberos_equipos**(**<u>cod_bombero</u>** PK FK: _int_, **<u>cod_equipo</u>** PK FK: _int_, puesto: _varchar(50)_)