// Crea un programa que solicite al usuario ingresar un número y determine si es divisible
// entre 3.

'use strict';

let valor;
do {
  valor = prompt('Introduce el valor numerico de valor', 5);
} while (isNaN(valor));

let result =
  valor % 3 === 0 ? 'Si es divisible entre 3' : 'No es divisible entre 3';
console.log(result);
