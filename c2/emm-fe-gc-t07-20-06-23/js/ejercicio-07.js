// Escribe un programa que pida al usuario ingresar su edad y verifique si es mayor de edad
// (18 años o más).

'use strict';

let edad;
do {
  edad = prompt('Introduce la edad de un usuario');
} while (isNaN(edad));

let result = edad >= 18 ? 'Es mayor de edad' : 'Es menor de edad';

console.log(result);
