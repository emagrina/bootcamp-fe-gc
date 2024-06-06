// Crea un array de números de un tamaño pasado por prompt, el array contendránúmeros
// aleatorios entre 1 y 300 y mostrará aquellos números que acaben en un dígito que
// nosotros le indiquemos por prompt (debes controlar que se introduce un número
// correcto), estos deben guardarse en un nuevo array. Por ejemplo, en un array de 10
// posiciones le indicamos mostrar los números acabados en 5, podría salir 155, 25, etc.

'use strict';

const generateRandomArray = (size) => {
  const array = [];
  for (let i = 0; i < size; i++) {
    const randomNumber = Math.floor(Math.random() * 300) + 1;
    array.push(randomNumber);
  }
  return array;
};

const filterArrayByDigit = (array, digit) => {
  const filteredArray = [];
  array.forEach((number) => {
    const lastDigit = number % 10;
    if (lastDigit === digit) {
      filteredArray.push(number);
    }
  });
  return filteredArray;
};

let size;
do {
  size = parseInt(prompt('Introduzca la longitud del array:'));
} while (isNaN(size) || size <= 0);

let digit;
do {
  digit = parseInt(
    prompt('Introduce el ultimo dijisto que quieres mostrar (0-9):')
  );
} while (isNaN(digit) || digit < 0 || digit > 9);

const randomArray = generateRandomArray(size);
const filteredArray = filterArrayByDigit(randomArray, digit);

console.log('Array:', randomArray);
console.log('Array que tengan el ultomo dijiste insertado', filteredArray);
