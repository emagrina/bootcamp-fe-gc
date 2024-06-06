SELECT c.DNI, c.NomApels, COALESCE(SUM(p.Horas), 0) AS TotalHours
FROM cientificos c
LEFT JOIN asignado_a a ON c.DNI = a.cientifico
LEFT JOIN proyecto p ON a.proyecto = p.id
GROUP BY c.DNI, c.NomApels;
