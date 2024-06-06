// Crea un programa que solicite al usuario ingresar un número y luego calcule la suma de
// todos los números impares desde 1 hasta ese número utilizando un bucle `while` y una
// condición `if`.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 10));
} while (isNaN(value) || value < 0);

let suma = 0;
let i = 1;

while (i <= value) {
  if (i % 3 == 0) {
    suma += i;
  }
  i++;
}

console.log(suma);
