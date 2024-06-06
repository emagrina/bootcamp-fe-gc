// Crea un programa que solicite al usuario ingresar un número y muestre en la consola todos
// los números pares desde ese número hasta 0 utilizando un bucle `while`.

'use strict';

let value;
do {
  value = parseInt(prompt('Introduce un valor numerico', 10));
} while (isNaN(value));

while (value > 0) {
  if (value % 2 === 0) {
    console.log(value);
  }
  value -= 2;
}
