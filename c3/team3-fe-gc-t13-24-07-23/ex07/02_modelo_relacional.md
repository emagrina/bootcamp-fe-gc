**arrendatarios**(**<u>cif/nif_arrendatario</u>** PK: _varchar(30)_, nombre_fiscal: _varchar(100)_, nombre_firmante: _varchar(100)_, direccion: _varchar(200)_, codigo_postal: _int_, localidad: _varchar(50)_, provincia: _varchar(50)_, telefono_fijo: _int_, telefono_movil: _int_, fax: _int_, actividad: _varchar(200)_)

**naves**(**<u>cod_nave</u>** PK: _int_, poligono: _varchar(200)_, calle: _varchar(100)_, numero: _int_, localidad: _varchar(50)_, codigo_postal: _int_, provincia: _varchar(50)_, telefono: _int_,  caracteristicas: _varchar(300)_, foto: _varchar(100)_, datos_escritura: _varchar(100)_, alquilada: _boolean_, gastos_comunidad: _float_)

**recibos**(**<u>numero_recibos</u>** PK: _int_, importe_total: _float_, importe_iva: _float_, pagado: _boolean_, fecha: _date_)

**arrendatarios_naves**(**<u>arrendatarios_cif/nif_arrendatario</u>** PK FK: _varchar(30)_, **<u>naves_cod_nave</u>** PK FK: _int_, numero_cuenta: _int_,  dias_pago: _int_, fecha_alquiler: _date_, fecha_fin_alquiler: _date_, importe_alquiler: _float_)

**naves_recibos**(**<u>naves_cod_nave</u>** PK FK: _int_, **<u>recibos_numero_recibos</u>** PK FK: _int_)