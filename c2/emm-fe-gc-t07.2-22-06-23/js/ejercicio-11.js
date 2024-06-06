// Crea dos arrays de números con la dimensión pasada por teclado. Uno de ellos estará
// rellenado con números aleatorios y el otro apuntará al array anterior, reasigna los valores
// del segundo array con valores aleatorios. Después, crea un método que tenga como
// parámetros, los dos arrays y devuelva uno nuevo con la multiplicación de la posición 0
// del array1 con el del array2 y así sucesivamente. Por último, muestra el contenido de
// cada array.

'use strict';

const generateRandomArray = (size) => {
  const array = [];
  for (let i = 0; i < size; i++) {
    const randomNumber = Math.floor(Math.random() * 100);
    array.push(randomNumber);
  }
  return array;
};

const multiplyArrays = (array1, array2) => {
  const resultArray = [];
  for (let i = 0; i < array1.length; i++) {
    const multipliedValue = array1[i] * array2[i];
    resultArray.push(multipliedValue);
  }
  return resultArray;
};

let size;
do {
  size = parseInt(prompt('Introduzca la longitud del array:'));
} while (isNaN(size) || size <= 0);

const randomArray1 = generateRandomArray(size);
const randomArray2 = randomArray1.slice();

const multipliedArray = multiplyArrays(randomArray1, randomArray2);

console.log('Array 1:', randomArray1);
console.log('Array 2:', randomArray2);
console.log('Multiplicacion:', multipliedArray);
