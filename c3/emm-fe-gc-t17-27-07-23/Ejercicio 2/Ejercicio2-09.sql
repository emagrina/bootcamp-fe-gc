SELECT d.codigo, COUNT(e.nombre) AS 'Numero Empleados'
FROM actividades.empleados e
INNER JOIN actividades.departamentos d
	ON e.departamento = d.codigo
GROUP BY d.codigo;
