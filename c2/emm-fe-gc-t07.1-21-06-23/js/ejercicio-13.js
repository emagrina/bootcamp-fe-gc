// Crea un objeto que contenga una receta de cocina, con propiedades asignadas a su
// nombre, tiempo de preparación e ingredientes. Haz una función que saque por consola
// el nombre, el tiempo y una lista de los ingredientes.

'use strict';

const receta = {
  nombre: 'Tarta de Manzana',
  tiempoPreparacion: '1 hora',
  ingredientes: ['manzanas', 'azúcar', 'harina', 'mantequilla', 'canela'],
};

const mostrarReceta = ({ nombre, tiempoPreparacion, ingredientes }) => {
    console.log(nombre);
    console.log(tiempoPreparacion);
    for (const ingrediente of ingredientes) {
        console.log('-', ingrediente);
    }
}

mostrarReceta(receta);
