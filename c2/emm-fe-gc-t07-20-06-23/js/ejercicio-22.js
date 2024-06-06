// Escribe un programa que solicite al usuario ingresar una palabra y muestre en la consola
// cada letra de la palabra en una línea diferente utilizando un bucle `for`.

'use strict';

let value;
do {
  value = prompt('Introduce una palabra', 'Hello world!');
} while (!value || value.trim() === '');

for (let i = 0; i < value.length; i++) {
  console.log(value[i]);
}
