// Crea una string, pásala a array y saca por consola la versión invertida de la original.
// Ejemplo: "Hola" -> [H, o, l, a] -> [a, l, o, H] -> "aloH"

'use strict';

const word = 'Hola';
const wordArray = Array.from(word);
const wordReveredArray = wordArray.reverse();

const wordReversed = wordReveredArray.join('');

console.log('Palabra normal:', word);
console.log('Palabra inverida:', wordReversed);
