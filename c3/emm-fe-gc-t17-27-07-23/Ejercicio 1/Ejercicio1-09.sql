SELECT nombre, precio
FROM actividades.articulos
WHERE  precio >= 180
ORDER BY precio DESC, nombre ASC;