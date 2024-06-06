SELECT c.DNI, c.NomApels, COUNT(a.proyecto) AS ProyectosAsignados
FROM cientificos c
LEFT JOIN asignado_a a ON c.DNI = a.cientifico
GROUP BY c.DNI, c.NomApels;
