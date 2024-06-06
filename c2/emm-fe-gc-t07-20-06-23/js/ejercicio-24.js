// Realiza un programa que solicite al usuario ingresar un número y muestre en la consola la
// suma de todos los dígitos del número utilizando un bucle `while`.

'use strict';

let value;
do {
  value = prompt('Introduce un valor numérico positivo', 333);
} while (!value || value.trim() === '' || isNaN(parseInt(value)));

let suma = 0;

while (value > 0) {
  let digito = value % 10;
  suma += digito;
  value = Math.floor(value / 10);
}

console.log(suma);
