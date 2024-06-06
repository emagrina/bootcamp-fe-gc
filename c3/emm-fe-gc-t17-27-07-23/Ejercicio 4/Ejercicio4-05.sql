SELECT s.*, p.*
FROM actividades.salas s
LEFT JOIN actividades.peliculas p 
ON s.pelicula = p.codigo;
