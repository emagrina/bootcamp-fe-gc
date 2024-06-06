SELECT p.id AS IdentificadorProyecto, p.Nombre AS NombreProyecto, COUNT(a.cientifico) AS CientificosAsignados
FROM proyecto p
LEFT JOIN asignado_a a ON p.id = a.proyecto
GROUP BY p.id, p.Nombre;
