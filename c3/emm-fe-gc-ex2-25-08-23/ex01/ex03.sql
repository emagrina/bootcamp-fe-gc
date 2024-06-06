SELECT d.NomApels, de.capacidad
FROM directores AS d
JOIN despachos AS de ON d.Despacho = de.numero;
