// Utiliza el objeto del ejercicio anterior y mediante desestructuración accede únicamente
// a tres de esas propiedades.

'use strict';

const persona = {
  nombre: 'John',
  apellidos: 'Doe',
  edad: 30,
  direccion: '123 Main Street',
  ciudad: 'New York',
  pais: 'United States',
};

const { nombre, apellidos, edad } = persona;

console.log(nombre, apellidos, edad);
