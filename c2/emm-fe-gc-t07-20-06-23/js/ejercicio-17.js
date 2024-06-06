// Crea un programa que solicite al usuario ingresar un número y muestre en la consola todos
// los números pares desde 2 hasta ese número utilizando un bucle `while`.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico', 10));
} while (isNaN(value));

let numbersPars = 2;
while (numbersPars <= value) {
  console.log(numbersPars);
  numbersPars += 2;
}
