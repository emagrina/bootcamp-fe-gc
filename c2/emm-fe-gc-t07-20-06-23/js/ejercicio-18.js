// Realiza un programa que solicite al usuario ingresar un número y muestre en la consola la
// suma de todos los números naturales hasta ese número utilizando un bucle `do...while`.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico', 10));
} while (isNaN(value));

let sum = 0;
let count = 1;

do {
  sum += count;
  count++;
} while (count <= value);

console.log(sum);
