// Crea una aplicación que nos genere una cantidad de números enteros aleatorios pasados
// por el usuario (prompt). Crea un método donde pasamos como parámetros entre entre
// qué números queremos que los genere, podemos pedirlas al usuario antes de generar
// los números. Este método devolverá un número entero aleatorio. Muestra estos
// números por consola.

'use strict';

const getRandomNumber = (min, max) => {
  return Math.floor(Math.random() * (max - min + 1)) + min;
};

const printRandomNumbers = (min, max) => {
  for (let i = 0; i < getRandomNumber(min, max); i++) {
    const randomNum = getRandomNumber(min, max);
    console.log(randomNum);
  }
};

let rangeParameters = {
  min,
  max,
};

let { min, max } = rangeParameters;

do {
  min = parseInt(prompt('Introduce el valor mínimo del rango:', 1));
} while (isNaN(min) || min === null);

do {
  max = parseInt(prompt('Introduce el valor máximo del rango:', 5));
} while (isNaN(max) || max === null);

printRandomNumbers(min, max);
