// Utilizando el array del ejercicio anterior, crea una función que saque por consola
// únicamente los números mayores que 5.

'use strict';

const olderThanFive = (numArray) => {
  const newNumArray = [];

  for (const num of numArray) {
    if (num > 5) {
      newNumArray.push(num);
    }
  }

  return newNumArray;
};

const numArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

const olderFiveArray = olderThanFive(numArray);

console.log(olderFiveArray);
