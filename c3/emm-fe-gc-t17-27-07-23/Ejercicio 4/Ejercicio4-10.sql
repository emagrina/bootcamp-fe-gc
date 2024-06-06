DELETE FROM actividades.salas
WHERE pelicula IN (
  SELECT codigo
  FROM actividades.peliculas
  WHERE calificacionedad = 'G'
);
