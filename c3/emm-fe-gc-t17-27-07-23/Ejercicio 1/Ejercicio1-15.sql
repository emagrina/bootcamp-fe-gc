SELECT nombre, MIN(precio) AS 'Precio Más Barato'
FROM actividades.articulos
GROUP BY nombre;
