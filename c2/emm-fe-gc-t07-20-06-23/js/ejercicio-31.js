// Realiza un programa que solicite al usuario ingresar un número y luego muestre en la
// consola todos los números primos desde 1 hasta ese número utilizando un bucle `for`, una
// condición `if` y una función auxiliar para verificar si un número es primo.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 12));
} while (isNaN(value) || value < 0);

for (let numeroActual = 1; numeroActual <= value; numeroActual++) {
  if (esPrimo(numeroActual)) {
    console.log(`El número ${numeroActual} es primo.`);
  }
}

function esPrimo(numero) {
  if (numero < 2) {
    return false;
  }
  for (let i = 2; i * i <= numero; i++) {
    if (numero % i === 0) {
      return false;
    }
  }
  return true;
}
