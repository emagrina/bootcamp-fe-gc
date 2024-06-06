// Escribe un programa que solicite al usuario ingresar un número y luego calcule el factorial
// de ese número utilizando un bucle `for`, una condición `if` y una variable acumuladora.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 5));
} while (isNaN(value) || value < 0);

let factorial = 1;

if (value === 0) {
  console.log(`factorial(${value}) = 1`);
} else {
  let factorial = 1;
  for (let i = 1; i <= value; i++) {
    factorial *= i;
  }

  console.log(`factorial(${value}) = ${factorial}`);
}
