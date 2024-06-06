SELECT almacen, AVG(valor) AS 'Valor Medio'
FROM actividades.cajas
GROUP BY almacen;
