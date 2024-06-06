USE ex03;

-- INSERTS

INSERT INTO cientificos (dni, nom_apels) VALUES
('11111111', 'Científico 1'),
('22222222', 'Científico 2'),
('33333333', 'Científico 3'),
('44444444', 'Científico 4'),
('55555555', 'Científico 5'),
('66666666', 'Científico 6'),
('77777777', 'Científico 7'),
('88888888', 'Científico 8'),
('99999999', 'Científico 9'),
('12345678', 'Científico 10');

INSERT INTO proyectos (id, nombre, horas) VALUES
('P001', 'Proyecto A', 100),
('P002', 'Proyecto B', 200),
('P003', 'Proyecto C', 150),
('P004', 'Proyecto D', 120),
('P005', 'Proyecto E', 180),
('P006', 'Proyecto F', 90),
('P007', 'Proyecto G', 210),
('P008', 'Proyecto H', 80),
('P009', 'Proyecto I', 240),
('P010', 'Proyecto J', 170);

INSERT INTO asignado_a (cientifico, proyecto) VALUES
('11111111', 'P001'), 
('22222222', 'P002'),
('33333333', 'P003'),
('44444444', 'P004'),
('55555555', 'P005'),
('66666666', 'P006'),
('77777777', 'P007'),
('88888888', 'P008'),
('99999999', 'P009'),
('12345678', 'P010');

-- UPDATES

UPDATE cientificos SET nom_apels = 'Albert Einstein' WHERE dni = '11111111';
UPDATE cientificos SET nom_apels = 'Marie Curie' WHERE dni = '22222222';
UPDATE cientificos SET nom_apels = 'Isaac Newton' WHERE dni = '33333333';
UPDATE cientificos SET nom_apels = 'Nikola Tesla' WHERE dni = '44444444';
UPDATE cientificos SET nom_apels = 'Stephen Hawking' WHERE dni = '55555555';
UPDATE cientificos SET nom_apels = 'Galileo Galilei' WHERE dni = '66666666';
UPDATE cientificos SET nom_apels = 'Ada Lovelace' WHERE dni = '77777777';
UPDATE cientificos SET nom_apels = 'Charles Darwin' WHERE dni = '88888888';
UPDATE cientificos SET nom_apels = 'Rosalind Franklin' WHERE dni = '99999999';
UPDATE cientificos SET nom_apels = 'Alberto Santos Dumont' WHERE dni = '12345678';

UPDATE proyectos SET nombre = 'Proyecto Relatividad', horas = 120 WHERE id = 'P001';
UPDATE proyectos SET nombre = 'Proyecto Radioactividad', horas = 180 WHERE id = 'P002';
UPDATE proyectos SET nombre = 'Proyecto Leyes del Movimiento', horas = 150 WHERE id = 'P003';
UPDATE proyectos SET nombre = 'Proyecto Corriente Alterna', horas = 150 WHERE id = 'P004';
UPDATE proyectos SET nombre = 'Proyecto Agujeros Negros', horas = 150 WHERE id = 'P005';
UPDATE proyectos SET nombre = 'Proyecto Telescopio', horas = 150 WHERE id = 'P006';
UPDATE proyectos SET nombre = 'Proyecto Programación', horas = 150 WHERE id = 'P007';
UPDATE proyectos SET nombre = 'Proyecto Evolución', horas = 150 WHERE id = 'P008';
UPDATE proyectos SET nombre = 'Proyecto Estructura del ADN', horas = 150 WHERE id = 'P009';
UPDATE proyectos SET nombre = 'Proyecto Avión 14-Bis', horas = 150 WHERE id = 'P010';

-- DELETES

DELETE FROM proyectos WHERE id = 'P010' OR id = 'P006' OR id = 'P001';