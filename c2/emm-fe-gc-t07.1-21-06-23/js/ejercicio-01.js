// Dado el array ["A", "B", "C", "D", "E", "F", "G", "H", "I"] crea una función que saque por
// consola la longitud del array. Crea otra función que obtenga un elemento aleatorio del
// array y lo saque por consola.

'use strict';

const LETTERS_ARR = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'];

function arrayLength() {
    return LETTERS_ARR.length
}

function randomArrayElement() {
    const randomIndex = Math.floor(Math.random() * LETTERS_ARR.length);
    const elementRandom = LETTERS_ARR[randomIndex];
    return elementRandom
}

console.log(arrayLength());
console.log(randomArrayElement());