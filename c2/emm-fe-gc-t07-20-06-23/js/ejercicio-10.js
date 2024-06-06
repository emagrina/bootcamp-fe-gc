// Realiza un programa que solicite al usuario ingresar el día de la semana (como número del
// 1 al 7) y muestre en la consola el nombre del día correspondiente (por ejemplo, 1
// corresponde a "Lunes", 2 corresponde a "Martes", etc.).

'use strict';

let value;
do {
  value = prompt('Introduce el dia de la semana (1-7)', 5);
} while (isNaN(value) || value < 1 || value > 7);

const WEEK = [
  'Lunes',
  'Martes',
  'Miercoles',
  'Jueves',
  'Viernes',
  'Sabado',
  'Domingo',
];

console.log(WEEK[value - 1]);
