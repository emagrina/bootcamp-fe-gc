SELECT a.*, f.nombre
FROM actividades.articulos a
INNER JOIN actividades.fabricantes f
	ON a.fabricante = f.codigo