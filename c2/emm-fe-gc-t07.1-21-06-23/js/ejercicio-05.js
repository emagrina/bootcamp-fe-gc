// Crea dos arrays de la misma longitud y una función que cree un nuevo array que intercale
// sus elementos y vacíe los arrays originales. Por ejemplo, con los arrays arrayUno = [1, 2, 3]
// y arrayDos = [4, 5, 6] el resultado debería ser [1, 4, 2, 5, 3, 6]

'use strict';

const intercalarArrays = (arrayUno, arrayDos) => {
  const nuevoArray = [];

  for (let i = 0; i < arrayUno.length; i++) {
    nuevoArray.push(arrayUno[i]);
    nuevoArray.push(arrayDos[i]);
  }

  arrayUno.length = 0;
  arrayDos.length = 0;

  return nuevoArray;
};

const arrayUno = [1, 2, 3];
const arrayDos = [4, 5, 6];

const resultado = intercalarArrays(arrayUno, arrayDos);
console.log(resultado);

console.log(arrayUno);
