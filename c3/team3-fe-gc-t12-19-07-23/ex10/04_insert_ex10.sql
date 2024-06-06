INSERT INTO jugadores (id, nombre, apellido, fecha_nacimiento, nacionalidad, posicion, dorsal)
VALUES
(1, 'Lionel', 'Messi', '1987-06-24', 'Argentina', 'Delantero', 10),
(2, 'Cristiano', 'Ronaldo', '1985-02-05', 'Portugal', 'Delantero', 7),
(3, 'Neymar', 'da Silva', '1992-02-05', 'Brasil', 'Delantero', 11),
(4, 'Andrés', 'Iniesta', '1984-05-11', 'España', 'Centrocampista', 8),
(5, 'Sergio', 'Ramos', '1986-03-30', 'España', 'Defensa', 4),
(6, 'Manuel', 'Neuer', '1986-03-27', 'Alemania', 'Portero', 1),
(7, 'Eden', 'Hazard', '1991-01-07', 'Bélgica', 'Centrocampista', 10),
(8, 'Virgil', 'van Dijk', '1991-07-08', 'Países Bajos', 'Defensa', 4),
(9, 'Kylian', 'Mbappé', '1998-12-20', 'Francia', 'Delantero', 7),
(10, 'Luka', 'Modrić', '1985-09-09', 'Croacia', 'Centrocampista', 10);

INSERT INTO temporadas (cod_temp, fecha_inicio, fecha_final)
VALUES
(1, '2021-08-01', '2022-05-30'),
(2, '2022-08-01', '2023-05-30'),
(3, '2023-08-01', '2024-05-30'),
(4, '2024-08-01', '2025-05-30'),
(5, '2025-08-01', '2026-05-30'),
(6, '2026-08-01', '2027-05-30'),
(7, '2027-08-01', '2028-05-30'),
(8, '2028-08-01', '2029-05-30'),
(9, '2029-08-01', '2030-05-30'),
(10, '2030-08-01', '2031-05-30');

INSERT INTO partidos (id, fecha, estadio, id_jugador, cod_temp)
VALUES
(1, '2022-01-15', 'Estadio Santiago Bernabéu', 1, 2),
(2, '2022-03-10', 'Camp Nou', 2, 2),
(3, '2022-02-20', 'Parc des Princes', 3, 2),
(4, '2022-04-05', 'Allianz Arena', 4, 2),
(5, '2022-02-28', 'Anfield', 5, 2),
(6, '2022-01-25', 'San Siro', 6, 2),
(7, '2022-03-12', 'Wanda Metropolitano', 7, 2),
(8, '2022-03-20', 'Signal Iduna Park', 8, 2),
(9, '2022-02-10', 'Old Trafford', 9, 2),
(10, '2022-03-08', 'Johan Cruyff Arena', 10, 2);

INSERT INTO equipos_locales (cod_local, id_partido)
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);

INSERT INTO equipos_visitantes (cod_visitante, id_partido)
VALUES
(11, 1),
(12, 2),
(13, 3),
(14, 4),
(15, 5),
(16, 6),
(17, 7),
(18, 8),
(19, 9),
(20, 10);

INSERT INTO estadisticas (cod_estadisticas, goles_anotados, asistencias, targ_amarillas, targ_rojas, id_partido, id_jugador)
VALUES
(1, 2, 1, 0, 0, 1, 1),
(2, 3, 0, 1, 0, 2, 2),
(3, 1, 2, 1, 0, 3, 3),
(4, 0, 1, 1, 0, 4, 4),
(5, 1, 1, 0, 0, 5, 5),
(6, 0, 0, 0, 0, 6, 6),
(7, 2, 1, 1, 0, 7, 7),
(8, 1, 0, 0, 0, 8, 8),
(9, 0, 3, 1, 0, 9, 9),
(10, 1, 0, 0, 0, 10, 10);

INSERT INTO equipos (id, nombre, ciudad, fundacion, estadio, entrenador, id_jugador)
VALUES
(1, 'Real Madrid', 'Madrid', '1902-03-06', 'Estadio Santiago Bernabéu', 'Carlo Ancelotti', 1),
(2, 'FC Barcelona', 'Barcelona', '1899-11-29', 'Camp Nou', 'Ronald Koeman', 2),
(3, 'Paris Saint-Germain', 'Paris', '1970-08-12', 'Parc des Princes', 'Mauricio Pochettino', 3),
(4, 'Bayern Munich', 'Munich', '1900-02-27', 'Allianz Arena', 'Julian Nagelsmann', 4),
(5, 'Liverpool FC', 'Liverpool', '1892-06-03', 'Anfield', 'Jurgen Klopp', 5),
(6, 'AC Milan', 'Milan', '1899-12-16', 'San Siro', 'Stefano Pioli', 6),
(7, 'Atletico Madrid', 'Madrid', '1903-04-26', 'Wanda Metropolitano', 'Diego Simeone', 7),
(8, 'Borussia Dortmund', 'Dortmund', '1909-12-19', 'Signal Iduna Park', 'Marco Rose', 8),
(9, 'Manchester United', 'Manchester', '1878-04-01', 'Old Trafford', 'Ole Gunnar Solskjaer', 9),
(10, 'Ajax Amsterdam', 'Amsterdam', '1900-03-18', 'Johan Cruyff Arena', 'Erik ten Hag', 10);