SELECT almacen
FROM actividades.cajas
GROUP BY almacen
HAVING AVG(valor) > 150;
