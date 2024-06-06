// Crea un array con los nombres de los planetas del Sistema Solar. Crea una función que
// los liste y los saque por consola.

'use strict';

const PLANETS = ["Mercurio", "Venus", "Tierra", "Marte", "Júpiter", "Saturno", "Urano", "Neptuno"];

function planetsList() {
    for (const planet of PLANETS) {
        console.log(planet);
    }
}