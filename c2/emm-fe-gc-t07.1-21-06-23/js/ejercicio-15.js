//  Haz lo mismo declarando una clase "receta" e instanciando cada una de las nuevas
// recetas. Luego añádelas a un array y reutiliza la función que habías creado en el ejercicio
// anterior para sacarlas por consola.

'use strict';

class Receta {
  constructor(nombre, tiempoPreparacion, ingredientes) {
    this.nombre = nombre;
    this.tiempoPreparacion = tiempoPreparacion;
    this.ingredientes = ingredientes;
  }
}

const mostrarReceta = (recetas) => {
  for (const receta of recetas) {
    const { nombre, tiempoPreparacion, ingredientes } = receta;
    console.log(`%c${nombre}`, 'color: brown;');
    console.log(tiempoPreparacion);
    for (const ingrediente of ingredientes) {
      console.log('•', ingrediente);
    }
  }
};

const tartaDeManzana = new Receta('Tarta de Manzana', '1 hora', [
  'manzanas',
  'azúcar',
  'harina',
  'mantequilla',
  'canela',
]);

const pastelDeChocolate = new Receta('Pastel de Chocolate', '45 minutos', [
  'chocolate',
  'azúcar',
  'harina',
  'mantequilla',
  'huevos',
]);

const pudinDeVainilla = new Receta('Pudin de Vainilla', '30 minutos', [
  'leche',
  'azúcar',
  'huevos',
  'vainilla',
]);

const recetas = [tartaDeManzana, pastelDeChocolate, pudinDeVainilla];

mostrarReceta(recetas);
