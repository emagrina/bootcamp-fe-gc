SELECT pr.Nombre AS NombreProveedor, pz.Nombre AS NombrePieza, s.Precio
FROM proveedores pr
INNER JOIN suministra s ON pr.id = s.IdProveedor
INNER JOIN piezas pz ON s.CodigoPieza = pz.Codigo
WHERE s.Precio = (SELECT MAX(Precio) FROM suministra)
ORDER BY s.Precio DESC;
