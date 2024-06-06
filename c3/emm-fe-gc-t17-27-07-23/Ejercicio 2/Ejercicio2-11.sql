SELECT e.nombre, e.apellidos, d.nombre, d.presupuesto
FROM actividades.empleados e
INNER JOIN actividades.departamentos d
	ON e.departamento = d.codigo;
