// Escribe un programa que solicite al usuario ingresar una palabra y luego cuente y muestre
// en la consola la cantidad de vocales que tiene la palabra utilizando un bucle `for`, una
// condición `if` y una variable contador.

'use strict';

let value;
do {
  value = prompt('Introduce una palabra', 'Hello');
} while (!value || value.trim() === '');

const vowels = ['a', 'e', 'i', 'o', 'u'];
let counter = 0;

for (let i = 0; i < value.length; i++) {
  const letter = value[i].toLowerCase();

  if (vowels.includes(letter)) {
    counter++;
  }
}

console.log(counter);
