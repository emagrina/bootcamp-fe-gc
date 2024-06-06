// Realiza un programa que solicite al usuario ingresar un número y luego muestre en la
// consola si ese número es primo o no utilizando un bucle `for`, una condición `if` y un
// contador de divisores.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 12));
} while (isNaN(value) || value < 0);

let esPrimo = true;

for (let i = 2; i < value; i++) {
  if (value % i === 0) {
    esPrimo = false;
  }
}

console.log(`El numero es ${esPrimo ? 'primo' : 'compuesto'}`);
