SELECT a.nombre, a.precio, f.nombre
FROM actividades.articulos a
INNER JOIN actividades.fabricantes f
	ON a.fabricante = f.codigo