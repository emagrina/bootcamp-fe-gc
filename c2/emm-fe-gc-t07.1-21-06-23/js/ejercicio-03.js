// Dado el array javascript1 = ["DOM", "BOM", "Funciones", "Arrays"], elimina "DOM" del
// array. Añade en su lugar el elemento "Objetos". Elimina el elemento "Arrays". Añade en
// su lugar el elemento "ArraysDifíciles". Haz una copia del array que solo incluya los
//últimos dos elementos. Obtén el índice del elemento "Funciones".

'use strict';

const javascript1 = ['DOM', 'BOM', 'Funciones', 'Arrays'];

javascript1.splice(javascript1.indexOf('DOM'), 1, 'Objetos');
javascript1.splice(javascript1.indexOf('Arrays'), 1, 'ArraysDifíciles');

const lastTwoElements = javascript1.slice(-2);
const positionElement = javascript1.indexOf("Funciones");

console.log('Cambios de DOM por Objetos y Arrays por ArraysDifíciles:', javascript1);
console.log('Creamos una copia y solo incluymos los dos ultimos elementos:', lastTwoElements);
console.log('El elemento Funciones esta en la posicion:', positionElement);