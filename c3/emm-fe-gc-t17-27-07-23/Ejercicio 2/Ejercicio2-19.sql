DELETE FROM actividades.empleados
WHERE departamento IN (
	SELECT codigo 
    FROM actividades.departamentos 
    WHERE presupuesto > 60000
);
