SELECT d1.NomApels AS NombreDirector, d2.NomApels AS NombreJefe
FROM directores AS d1
LEFT JOIN directores AS d2 ON d1.DNIJefe = d2.DNI;
