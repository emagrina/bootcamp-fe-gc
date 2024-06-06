DELETE c
FROM actividades.cajas c
INNER JOIN (
	SELECT a.codigo
	FROM actividades.almacenes a
	LEFT JOIN actividades.cajas c
	ON a.codigo = c.almacen
	GROUP BY a.codigo, a.capacidad
	HAVING COUNT(c.numreferencia) >= a.capacidad
) AS almacenes_saturados
ON c.almacen = almacenes_saturados.codigo;
