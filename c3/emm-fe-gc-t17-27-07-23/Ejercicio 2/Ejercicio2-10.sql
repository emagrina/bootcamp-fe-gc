SELECT e.*, d.*
FROM actividades.empleados e
INNER JOIN actividades.departamentos d
	ON e.departamento = d.codigo;
