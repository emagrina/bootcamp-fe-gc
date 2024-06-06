INSERT INTO cientificos (DNI, NomApels) VALUES ('Y6549437', 'Rafael Belda');
INSERT INTO proyecto (id, Nombre, Horas) values ('IASD', 'Industrial Automation Software Development', 90);
INSERT INTO proyecto (id, Nombre, Horas) values ('ARAM', 'AI Research Applied to Medicine', 100);
INSERT INTO asignado_a(cientifico, proyecto) values('Y6549437','IASD');
INSERT INTO asignado_a(cientifico, proyecto) values('Y6549437','ARAM');


SELECT c.DNI, c.NomApels
FROM cientificos c
JOIN (
    SELECT cientifico, COUNT(DISTINCT proyecto) AS num_proyectos, AVG(Horas) AS MediaDedicacion
    FROM asignado_a
    JOIN proyecto ON asignado_a.proyecto = proyecto.id
    GROUP BY cientifico
    HAVING num_proyectos > 1 AND MediaDedicacion > 80
) cientificos ON c.DNI = cientificos.cientifico;
