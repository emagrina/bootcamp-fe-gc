SELECT d.*
FROM directores AS d
INNER JOIN (
    SELECT DNI
    FROM directores
    WHERE DNIJefe IS NULL
) AS jefes_sin_jefe ON d.DNIJefe = jefes_sin_jefe.DNI;
