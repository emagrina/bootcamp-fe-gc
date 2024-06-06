SELECT d.Despacho, COUNT(*) AS NumDirectores, dp.capacidad
FROM directores AS d
INNER JOIN despachos AS dp ON d.Despacho = dp.numero
GROUP BY d.Despacho, dp.capacidad
HAVING NumDirectores > dp.capacidad;
