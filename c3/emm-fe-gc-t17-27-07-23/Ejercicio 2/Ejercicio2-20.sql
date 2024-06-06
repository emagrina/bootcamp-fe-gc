-- La forma simple que creo que es la que pides 
-- seria desactivando el safe mode y borrando el contendio

SET SQL_SAFE_UPDATES = 0;

DELETE FROM actividades.empleados;

SET SQL_SAFE_UPDATES = 1;
