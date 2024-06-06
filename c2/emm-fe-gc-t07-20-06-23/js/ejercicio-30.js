// Crea un programa que solicite al usuario ingresar un número y luego determine si es un
// número perfecto (la suma de sus divisores propios es igual al número) utilizando un bucle
// `while`, una condición `if` y una variable acumuladora.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico positivo', 10));
} while (isNaN(value) || value < 0);

let suma = 0;
let i = 1;

while (i < value) {
  if (value % i == 0) {
    suma += i;
  }
  i++;
}

console.log(
  value === suma ? `${value} es perfecto` : `${value} no es perfecto`
);
