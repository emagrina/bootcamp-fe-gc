// Crea una aplicación que nos calcule el área de un círculo, cuadrado o triángulo.
// Pediremos al usuario que figura queremos calcular su área y según lo introducido pedirá
// los valores necesarios para calcular el área. Para ello has de crear un método por cada
// figura para calcular cada área, este devolverá un número real. Muestra el resultado por
// consola.
// Aquí te mostramos que necesita cada figura:
// • Circulo: (radio^2)*PI
// • Triangulo: (base * altura) / 2
// • Cuadrado: lado * lado

'use strict';
const calcularAreaCirculo = (radio) => {
  return Math.PI * Math.pow(radio, 2);
};

const calcularAreaTriangulo = (base, altura) => {
  return (base * altura) / 2;
};

const calcularAreaCuadrado = (lado) => {
  return lado * lado;
};


const calcularAreaFigura = (figura) => {
  let area;

  switch (figura) {
    case 'círculo':
      let radio;
      do {
        radio = parseFloat(prompt('Introduce el RADIO del círculo:'));
      } while (isNaN(radio) || radio === null);

      area = calcularAreaCirculo(radio);
      console.log(`(${radio}^2) * π = ${area}`);
      break;

    case 'triángulo':
      let base;
      do {
        base = parseFloat(prompt('Introduce la BASE del triángulo:'));
      } while (isNaN(base) || base === null);

      let altura;
      do {
        altura = parseFloat(prompt('Introduce la ALTURA del triángulo:'));
      } while (isNaN(altura) || altura === null);

      area = calcularAreaTriangulo(base, altura);
      console.log(`(${base} * ${altura}) / 2 = ${area}`);
      break;

    case 'cuadrado':
      let lado;
      do {
        lado = parseFloat(prompt('Introduce el LADO del cuadrado:'));
      } while (isNaN(lado) || lado === null);

      area = calcularAreaCuadrado(lado);
      console.log(`${lado} * ${lado} = ${area}`);
      break;
  }
};

let figura;
do {
  figura = prompt(
    'Introduce la figura (círculo, triángulo, cuadrado):',
    'círculo'
  );
} while (!['círculo', 'triángulo', 'cuadrado'].includes(figura));

calcularAreaFigura(figura);
