SELECT p.*, s.*
FROM actividades.peliculas p
LEFT JOIN actividades.salas s ON p.codigo = s.pelicula;
