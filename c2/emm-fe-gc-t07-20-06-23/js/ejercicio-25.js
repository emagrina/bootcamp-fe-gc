// Escribe un programa que solicite al usuario ingresar una frase y muestre en la consola cada
// palabra de la frase en una línea diferente utilizando un bucle `for...of`.

'use strict';

let value;
do {
  value = prompt(
    'Introduce un valor numérico positivo',
    'No hay viento favorable para el que no sabe adónde va'
  );
} while (!value || value.trim() === '');

let word = value.split(' ');

for (const letter of word) {
  console.log(letter);
}
