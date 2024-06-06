// Dados los arrays javascript1 = ["DOM", "BOM", "Funciones", "Arrays"] y javascript2 =
// ["Objetos", "Arrays", "ParseInt"], crea una función que determine si se repite algún
// elemento y lo saque por consola.

'use strict';

const findDuplicateElements = (javascript1, javascript2) => {
  const duplicatedElements = javascript1.filter((element) =>
  javascript2.includes(element)
  );
  console.log(duplicatedElements);
};

const javascript1 = ['DOM', 'BOM', 'Funciones', 'Arrays'];
const javascript2 = ['Objetos', 'Arrays', 'ParseInt'];

findDuplicateElements(javascript1, javascript2);
