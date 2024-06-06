// Crea un array de números de un tamaño pasado por prompt, el array contendrá números
// aleatorios primos entre los números deseados, por último, nos indica cuál es el mayor
// de todos. Haz un método para comprobar que el número aleatorio es primo, puedes
// hacer todos los métodos que necesites.

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

const generatePrimeNumber = (min, max) => {
  let randomNumber;
  do {
    randomNumber = Math.floor(Math.random() * (max - min + 1)) + min;
  } while (!isPrime(randomNumber));
  return randomNumber;
};

const createPrimeArray = (size, min, max) => {
  const array = [];
  for (let i = 0; i < size; i++) {
    const primeNumber = generatePrimeNumber(min, max);
    array.push(primeNumber);
  }
  return array;
};

const findLargestNumber = (primesArray) => {
  let largestNumber = primesArray[0];
  for (let i = 1; i < primesArray.length; i++) {
    if (primesArray[i] > largestNumber) {
      largestNumber = primesArray[i];
    }
  }
  return largestNumber;
};

let size;
do {
  size = parseInt(prompt('Introduzca la longitud del array:'));
} while (isNaN(size) || size <= 0);

let min;
do {
  min = parseInt(prompt('Introduzca el valor minimo:'));
} while (isNaN(min) || min <= 0);

let max;
do {
  max = parseInt(prompt('Introduzca el valor maximo:'));
} while (isNaN(max) || max <= 0);

const primesArray = createPrimeArray(size, min, max);
const largesNumber = findLargestNumber(primesArray);

console.log(primesArray);
console.log(largesNumber);
