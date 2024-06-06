// Crea un programa que solicite al usuario ingresar una palabra y luego muestre en la
// consola la palabra invertida utilizando un bucle `while`, una condición `if` y una variable
// acumuladora.

'use strict';

let word;
do {
  word = prompt('Introduce una palabra', 'Hello world!');
} while (!word || word.trim() === '');

let invertedWord = '';
let index = word.length - 1;

while (index >= 0) {
  if (word.charAt(index)) {
    invertedWord += word.charAt(index);
  }
  index--;
}

console.log(invertedWord);
