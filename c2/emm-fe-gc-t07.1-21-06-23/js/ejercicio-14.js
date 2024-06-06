// Reutiliza la receta del ejercicio anterior y añádela a un array que contenga varias recetas
// similares, con las mismas propiedades. Utiliza también la función del ejercicio anterior y
// saca por consola todas las recetas de tu array

'use strict';

const mostrarReceta = (recetas) => {
    for (const receta of recetas) {
        const {nombre, tiempoPreparacion, ingredientes } = receta;
        console.log(`%c${nombre}`, 'color: brown;'); // Le puse algo de estilos para mejorar la legibilidad
        console.log(tiempoPreparacion);
        for (const ingrediente of ingredientes) {
            console.log('•', ingrediente);
        }
    }
}

const recetas = [
  {
    nombre: 'Tarta de Manzana',
    tiempoPreparacion: '1 hora',
    ingredientes: ['manzanas', 'azúcar', 'harina', 'mantequilla', 'canela'],
  },
  {
    nombre: 'Pastel de Chocolate',
    tiempoPreparacion: '45 minutos',
    ingredientes: ['chocolate', 'azúcar', 'harina', 'mantequilla', 'huevos'],
  },
  {
    nombre: 'Pudin de Vainilla',
    tiempoPreparacion: '30 minutos',
    ingredientes: ['leche', 'azúcar', 'huevos', 'vainilla'],
  },
];

mostrarReceta(recetas)