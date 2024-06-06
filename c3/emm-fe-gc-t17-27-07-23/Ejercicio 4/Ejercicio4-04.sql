SELECT s.*
FROM actividades.salas s
LEFT JOIN actividades.peliculas p 
ON s.pelicula = p.codigo
WHERE p.codigo IS NULL;
