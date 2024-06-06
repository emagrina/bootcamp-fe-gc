SELECT c.DNI, c.NomApels,
       p.id, p.Nombre
FROM cientificos c
INNER JOIN asignado_a a ON c.DNI = a.cientifico
INNER JOIN proyecto p ON a.proyecto = p.id;
