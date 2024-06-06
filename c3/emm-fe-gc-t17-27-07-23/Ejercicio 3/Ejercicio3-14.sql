UPDATE actividades.cajas
SET valor = valor * 0.8
WHERE valor > (
    SELECT sub.valor_medio
    FROM (
		SELECT AVG(valor) AS valor_medio 
		FROM actividades.cajas
	) AS sub
);
