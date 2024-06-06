SELECT nombre
FROM actividades.peliculas
WHERE codigo NOT IN (
  SELECT DISTINCT pelicula
  FROM actividades.salas
  WHERE pelicula IS NOT NULL
);
