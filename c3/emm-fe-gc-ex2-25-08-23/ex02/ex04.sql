SELECT p.Nombre
FROM proveedores p
INNER JOIN suministra s ON p.id = s.IdProveedor
WHERE s.CodigoPieza = 1;
