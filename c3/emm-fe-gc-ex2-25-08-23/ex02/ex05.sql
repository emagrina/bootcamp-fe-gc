SELECT pz.Nombre
FROM piezas pz
INNER JOIN suministra s ON pz.Codigo = s.CodigoPieza
WHERE s.IdProveedor = 'HAL';
