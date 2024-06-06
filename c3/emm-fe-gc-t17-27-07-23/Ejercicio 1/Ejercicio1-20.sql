SELECT codigo, nombre, 
       CASE 
           WHEN precio >= 120 THEN precio - 10 
           ELSE precio
       END AS 'Precio con Descuento', 
       fabricante
FROM actividades.articulos;
