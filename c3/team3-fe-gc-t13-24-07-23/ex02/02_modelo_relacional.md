**elementos**(**<u>nombre_elemento</u>** PK: _varchar(50)_, peso_atomico: _float_, simbolo: _varchar(2)_, n_atomico: _int_)

**compuestos**(**<u>nombre_compuesto</u>** PK: _varchar(50)_, estado: _varchar(30)_)

**elementos_compuestos**(_<u>nombre_compuesto</u>_ FK: _varchar(50)_, _<u>nombre_elemento</u>_ FK: _varchar(50)_, proporcion: _float_)

**gaseosos**(**_<u>nombre_compuesto</u>_** PK FK: _varchar(50)_, coef_expan: _float_, temp_lic: _int_)

**liquidos**(**_<u>nombre_compuesto</u>_** PK FK: _varchar(50)_, densidad: _float_, temp_evap: _int_)

**solidos**(**_<u>nombre_compuesto</u>_** PK FK: _varchar(50)_, color: _varchar(50)_, olor: _varchar(50)_, dureza: _float_)