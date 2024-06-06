// Crea un objeto que almacene los datos de una persona (nombre, apellidos, edad,
// dirección, ciudad, país... y lo que quieras). Crea una función que saque por consola el
// nombre completo (nombre y apellidos) de la persona a modo de string.

'use strict';

const nombreCompleto = ({ nombre, apellidos }) => {
  return `${nombre} ${apellidos}`;
};

const persona = {
  nombre: 'John',
  apellidos: 'Doe',
  edad: 30,
  direccion: '123 Main Street',
  ciudad: 'New York',
  pais: 'United States',
};

console.log(nombreCompleto(persona));
