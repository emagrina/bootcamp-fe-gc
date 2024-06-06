SELECT c.numreferencia, a.lugar AS 'Ciudad'
FROM actividades.cajas c
INNER JOIN actividades.almacenes a
ON c.almacen = a.codigo;
