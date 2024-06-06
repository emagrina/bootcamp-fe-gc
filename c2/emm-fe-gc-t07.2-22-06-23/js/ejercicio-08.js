// Crea un array de 10 posiciones de números con valores pedidos por prompt. Muestra
// por consola el índice y el valor al que corresponde. Haz dos métodos, uno para rellenar
// valores y otro para mostrar.

'use strict';

const fillValues = () => {
  const array = [];
  for (let i = 0; i < 10; i++) {
    let num;
    do {
      num = parseInt(prompt(`Introduzca un numero (${i + 1} - 10):`));
    } while (num < 0 || isNaN(num));
    array.push(num);
  }
  return array;
};

const displayValues = (array) => {
  array.forEach((value, index) => {
    console.log(`${index}: ${value}`);
  });
};

displayValues(fillValues());
