// Crea un array con al menos 10 números y una función que los divida en otros dos arrays:
// uno para pares y otro para impares. A continuación, saca por consola ambos arrays
// resultantes concatenados.

'use strict';

const separateEvenOdd = (numArray) => {
  const evens = [];
  const odds = [];

  for (const num of numArray) {
    if (num % 2 === 0) {
      evens.push(num);
    } else {
      odds.push(num);
    }
  }

  return { evens, odds };
};

const numArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

const { evens, odds } = separateEvenOdd(numArray);

const separatedArray = evens.concat(odds);
console.log(separatedArray);
