SELECT almacen, COUNT(*) AS 'Numero de Cajas'
FROM actividades.cajas
GROUP BY almacen;
