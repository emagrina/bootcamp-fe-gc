SELECT f.nombre AS 'Fabricante', AVG(a.precio) AS 'Precio Medio'
FROM actividades.articulos a
INNER JOIN actividades.fabricantes f
	ON a.fabricante = f.codigo
GROUP BY f.nombre


