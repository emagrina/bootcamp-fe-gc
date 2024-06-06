// Realiza un programa que solicite al usuario ingresar un número y muestre en la consola la
// multiplicación de todos los números enteros positivos menores o iguales a ese número
// utilizando un bucle `do...while`.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 10));
} while (isNaN(value) || value < 0);

let multiplicacion = 1;
let contador = 1;

do {
  multiplicacion *= contador;
  contador++;
} while (contador <= value);

console.log(multiplicacion);
