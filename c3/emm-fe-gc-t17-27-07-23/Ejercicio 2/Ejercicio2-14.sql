SELECT d.nombre
FROM actividades.empleados e
INNER JOIN actividades.departamentos d
    ON e.departamento = d.codigo
GROUP BY d.nombre
HAVING COUNT(e.departamento) > 2;
