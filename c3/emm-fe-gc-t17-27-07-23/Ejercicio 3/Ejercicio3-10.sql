SELECT c.numreferencia
FROM actividades.cajas c
INNER JOIN actividades.almacenes a
ON c.almacen = a.codigo
WHERE a.lugar = 'Bilbao';
