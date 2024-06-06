// Realiza un programa que solicite al usuario ingresar un número y determine si es par o impar.

'use strict';

let number = prompt('Introduce un valor numerico', 3);
let result = number % 2 == 0 ? 'Es par' : 'Es impar';

console.log(result);
