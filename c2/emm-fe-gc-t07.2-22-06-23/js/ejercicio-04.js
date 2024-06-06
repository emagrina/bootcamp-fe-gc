// Crea una aplicación que nos calcule el factorial de un número pedido por prompt, lo
// realizará mediante un método al que le pasamos el número como parámetro. Para
// calcular el factorial, se multiplica los números anteriores hasta llegar a uno. Por ejemplo,
// si introducimos un 5, realizará esta operación 5*4*3*2*1=120.

'use strict';

const calculateFactorial = (num) => {
  if (num === 0 || num === 1) {
    return 1;
  } else {
    let factorial = 1;
    for (let i = 2; i <= num; i++) {
      factorial *= i;
    }
    return factorial;
  }
};

let num;
do {
  num = parseInt(prompt('Introduce el valor numerico:', 10));
} while (isNaN(num) || num === null);

console.log(`(${num}) = ${calculateFactorial(num)}`);
