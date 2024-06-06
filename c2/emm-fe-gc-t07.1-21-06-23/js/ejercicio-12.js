// Crea un array que contenga al menos tres objetos con las mismas propiedades (al menos
// tres) y distintos valores. Crea una función que saque por consola el valor de una de las
// propiedades para todos los objetos.

'use strict';

const nombre = (containerArray) => {
  for (const objeto of containerArray) {
    const nombre = objeto.nombre;
    console.log(nombre);
  }
};

const containerArray = [
  {
    nombre: 'John',
    apellidos: 'Doe',
    edad: 30,
    direccion: '123 Main Street',
    ciudad: 'New York',
    pais: 'United States',
  },
  {
    nombre: 'Jane',
    apellidos: 'Smith',
    edad: 25,
    direccion: '456 Elm Street',
    ciudad: 'Los Angeles',
    pais: 'United States',
  },
  {
    nombre: 'Michael',
    apellidos: 'Johnson',
    edad: 35,
    direccion: '789 Oak Street',
    ciudad: 'Chicago',
    pais: 'United States',
  },
];

const nombreCompletoArray = nombre(containerArray);
