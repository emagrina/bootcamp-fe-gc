SELECT a.codigo
FROM actividades.almacenes a
INNER JOIN (
    SELECT almacen, COUNT(*) AS numero_de_cajas
    FROM actividades.cajas
    GROUP BY almacen
) c 
ON a.codigo = c.almacen
WHERE c.numero_de_cajas > a.capacidad;
