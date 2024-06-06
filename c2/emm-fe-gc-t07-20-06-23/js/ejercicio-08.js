// Crea un programa que pida al usuario ingresar tres números y determine cuál es el mayor
// de ellos.

'use strict';

let valores = {
  valor1: null,
  valor2: null,
  valor3: null,
};

let { valor1, valor2, valor3 } = valores;

do {
  valor1 = prompt('Introduce el valor numerico de valor1');
} while (isNaN(valor1));

do {
  valor2 = prompt('Introduce el valor numerico de valor2');
} while (isNaN(valor2));

do {
  valor3 = prompt('Introduce el valor numerico de valor3');
} while (isNaN(valor3));

let result = Math.max(valor1, valor2, valor3);

console.log(result);
