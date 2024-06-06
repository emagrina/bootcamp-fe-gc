// Crea un array de números donde le indicamos por prompt el tamaño del array,
// rellenaremos el array con números aleatorios entre 0 y 9. Al final muestra por consola el
// valor de cada posición y la suma de todos los valores. Tareas a realizar: Haz un método
// para rellenar el array(que tenga como parámetros los números entre los que tenga que
// generar) y otro para mostrar el contenido y la suma del array.

'use strict';

const fillArray = (size, min, max) => {
  const array = [];
  for (let i = 0; i < size; i++) {
    const randomNumber = Math.floor(Math.random() * (max - min + 1)) + min;
    array.push(randomNumber);
  }
  return array;
};

const displayArray = (array) => {
  let sum = 0;
  array.forEach((value, index) => {
    console.log(`Position ${index}: ${value}`);
    sum += value;
  });
  console.log(`Suma de todos los elementos: ${sum}`);
};

let size;
do {
  size = parseInt(prompt('Introduzca la longitud del array:'));
} while (isNaN(size) || size <= 0);


displayArray(fillArray(size, 0, 9));
