// Escribe un programa que muestre en la consola los números impares del 1 al 20 utilizando
// un bucle `for`.

'use strict';

for (let i = 1; i <= 20; i++) {
  if (i % 3 === 0) {
    console.log(i);
  }
}
