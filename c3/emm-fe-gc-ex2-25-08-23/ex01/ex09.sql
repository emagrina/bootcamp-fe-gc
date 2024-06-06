INSERT INTO directores (DNI, NomApels, DNIJefe, Despacho)
VALUES ('74568521', 'Alexandre Herranz', NULL, 124);

SET SQL_SAFE_UPDATES = 0;

UPDATE directores
SET DNIJefe = '74568521'
WHERE NomApels LIKE '%Pérez%';
