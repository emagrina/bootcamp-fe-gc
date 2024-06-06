// Realiza un programa que solicite al usuario ingresar dos números y determine si son iguales
// o diferentes.

'use strict';

let valores = {
  valor1: null,
  valor2: null,
};

let { valor1, valor2 } = valores;

do {
  valor1 = prompt('Introduce el valor numerico de valor1');
} while (isNaN(valor1));

do {
  valor2 = prompt('Introduce el valor numerico de valor2');
} while (isNaN(valor2));

let result = valor1 === valor2 ? 'Son iguales' : 'No son iguales';

console.log(result);
