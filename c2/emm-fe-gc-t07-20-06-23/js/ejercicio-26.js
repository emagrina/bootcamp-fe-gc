// Escribe un programa que solicite al usuario ingresar un número y luego muestre en la
// consola todos los números pares desde 0 hasta ese número utilizando un bucle `for` y una
// condición `if`.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 10));
} while (isNaN(value) || value < 0);

for (let i = 0; i <= value; i++) {
  if (i % 2 == 0) {
    console.log(i);
  }
}
