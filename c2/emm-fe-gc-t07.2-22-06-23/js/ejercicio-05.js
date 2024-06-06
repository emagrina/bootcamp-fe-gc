// Crea una aplicación que nos convierta un número en base decimal a binario. Esto lo
// realizará un método al que le pasaremos el número como parámetro, devolverá un
// String con el número convertido a binario. Para convertir un número decimal a binario,
// debemos dividir entre 2 el número y el resultado de esa división se divide entre 2 de
// nuevo hasta que no se pueda dividir más, el resto que obtengamos de cada división
// formará el número binario, de abajo a arriba.

const convertDecimalToBinary = (num) => {
  if (num === 0) {
    return '0';
  }

  let binary = '';
  while (num > 0) {
    let remainder = num % 2;
    binary = remainder + binary;
    num = Math.floor(num / 2);
  }

  return binary;
};

let num;
do {
  num = parseInt(prompt('Introduce el valor numerico decimal:', 10));
} while (isNaN(num) || num === null);

console.log(convertDecimalToBinary(num));
