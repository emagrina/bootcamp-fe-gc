// Escribe un programa que solicite al usuario ingresar un número y determine si es positivo,
// negativo o cero.

'use strict';

let valor;
do {
  valor = prompt('Introduce el valor numerico de valor', 5);
} while (isNaN(valor));

let result;

if (valor == 0) {
  result = 'El valor ingresado es cero';
} else {
  result =
    valor > 0
      ? 'El valor ingresado es positivo'
      : 'El valor ingresado es negativo';
}

console.log(result);
