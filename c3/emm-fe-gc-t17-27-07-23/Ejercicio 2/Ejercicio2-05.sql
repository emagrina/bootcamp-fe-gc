SELECT e.* 
FROM actividades.empleados e
INNER JOIN actividades.departamentos d
	ON e.departamento = d.codigo
WHERE d.codigo = 14