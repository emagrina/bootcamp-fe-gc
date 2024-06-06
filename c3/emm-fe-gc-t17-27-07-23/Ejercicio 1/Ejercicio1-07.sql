SELECT AVG(a.precio) AS 'Precio Medio'
FROM actividades.articulos a
INNER JOIN actividades.fabricantes f 
	ON a.fabricante = f.codigo
WHERE f.codigo = 2;