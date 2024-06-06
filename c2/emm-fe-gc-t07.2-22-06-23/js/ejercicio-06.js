// Crea una aplicación que nos cuente el número de cifras de un número entero positivo
// (hay que controlarlo) pedido por prompt. Crea un método que realice esta acción,
// pasando el número por parámetro devolverá el número de cifras.

'use strict';

const countDigits = (num) => {
  return num.toString().length;
};

let num;
do {
  num = parseInt(prompt('Introduce el valor numerico:', 1000));
} while (num < 0 || isNaN(num));

console.log(countDigits(num));
