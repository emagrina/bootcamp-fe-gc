SELECT d.Despacho, COUNT(*) AS NumeroDeDirectores
FROM directores AS d
GROUP BY d.Despacho;