INSERT INTO proveedores (id, Nombre) VALUES ('RBT', 'Susan Calvin Corp.');

UPDATE suministra
SET Precio = NULL
WHERE IdProveedor = 'RBT';

DELETE FROM suministra
WHERE IdProveedor = 'RBT'
  AND CodigoPieza IS NOT NULL;
