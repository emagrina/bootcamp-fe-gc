SELECT f.nombre AS 'Proveedor', a.nombre AS 'Artículo', a.precio AS 'Precio Más Caro'
FROM actividades.articulos a
INNER JOIN actividades.fabricantes f
    ON a.fabricante = f.codigo
WHERE (a.fabricante, a.precio) IN (
    SELECT fabricante, MAX(precio)
    FROM actividades.articulos
    GROUP BY fabricante
);
