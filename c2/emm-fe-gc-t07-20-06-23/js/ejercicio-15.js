// Escribe un programa que pida al usuario ingresar un año y determine si es bisiesto o no (un
// año es bisiesto si es divisible entre 4, pero no entre 100, a menos que también sea divisible
// entre 400).

'use strict';

let year;
do {
  year = prompt('Introduce un año', 2023);
} while (isNaN(year));

if ((year % 4 === 0 && year % 100 !== 0) || year % 400 === 0) {
  console.log(`${year} es un año bisiesto`);
} else {
  console.log(`${year} no es un año bisiesto`);
}
