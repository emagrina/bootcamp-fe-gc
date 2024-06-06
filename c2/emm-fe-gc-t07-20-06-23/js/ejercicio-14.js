// Crea un programa que solicite al usuario ingresar un número del 1 al 12 y muestre en la
// consola el nombre del mes correspondiente (por ejemplo, 1 corresponde a "Enero", 2
// corresponde a "Febrero", etc.).

'use strict';

let value;
do {
  value = prompt('Introduce el numero del mes (1-12)', 11);
} while (isNaN(value) || value < 1 || value > 12);

const MONTHS = [
  'Enero',
  'Febrero',
  'Marzo',
  'Abril',
  'Mayo',
  'Junio',
  'Julio',
  'Agosto',
  'Septiembre',
  'Octubre',
  'Noviembre',
  'Diciembre',
];

console.log(MONTHS[value - 1]);
