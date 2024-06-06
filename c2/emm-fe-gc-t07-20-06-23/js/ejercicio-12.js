// Escribe un programa que solicite al usuario ingresar su calificación en un examen y muestre
// en la consola si ha aprobado (calificación mayor o igual a 70) o no.

'use strict';

let value;
do {
  value = prompt('Introduce la nota del usuario (00-100)', 50);
} while (isNaN(value) || value < 0 || value > 100);

let result = value >= 70 ? 'Usuario aprobado' : 'Usuario suspendido';
console.log(result);
