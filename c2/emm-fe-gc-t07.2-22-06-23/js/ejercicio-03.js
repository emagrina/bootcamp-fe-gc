// Crea una aplicación que nos pida un número por prompt y con un método se lo pasamos
// por parámetro para que nos indique si es o no un número primo, debe devolver true si
// es primo sino false. Un número primo es aquel que solo puede dividirse entre 1 y sí
// mismo. Por ejemplo: 25 no es primo, ya que 25 es divisible entre 5, sin embargo, 17 si
// es primo.

'use strict';

const isPrime = (num) => {
  if (num < 2) {
    return false;
  }
  for (let i = 2; i * i <= num; i++) {
    if (num % i === 0) {
      return false;
    }
  }
  return true;
};

let num;
do {
  num = parseInt(prompt('Introduce el valor numerico:', 17));
} while (isNaN(num) || num === null);

console.log(isPrime(num) ? 'Es primo' : 'No es primo');
