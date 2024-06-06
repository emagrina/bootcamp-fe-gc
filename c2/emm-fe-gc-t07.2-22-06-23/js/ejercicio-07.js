// Crea una aplicación que nos convierta una cantidad de euros introducida por prompt a
// otra moneda, estas pueden ser a dólares, yenes o libras. El método tendrá como
// parámetros, la cantidad de euros y la moneda a pasar que será una cadena, este no
// devolverá ningún valor, mostrará un mensaje indicando el cambio.
// El cambio de divisas es:
// • 0.86 libras es un 1 €
// • 1.28611 $ es un 1 €
// • 129.852 yenes es un 1 €

'use strict';

const convertCurrency = (euros, currency) => {
  let convertedAmount;
  let message;

  switch (currency) {
    case 'dollars':
      convertedAmount = euros * 1.28611;
      message = `${euros}€ -> ${convertedAmount.toFixed(2)}$`;
      break;

    case 'yen':
      convertedAmount = euros * 129.852;
      message = `${euros}€ -> ${convertedAmount.toFixed(2)}¥`;
      break;

    case 'pounds':
      convertedAmount = euros * 0.86;
      message = `${euros}€ -> ${convertedAmount.toFixed(2)}£`;
      break;
  }

  console.log(message);
};

let euros;
do {
  euros = parseFloat(prompt('Introduce el dinero en euros:'));
} while (isNaN(euros) || euros < 0);

let currency;
do {
  currency = prompt('Introduzca la moneda a convertir (dollars, yen, pounds):');
} while (!['dollars', 'yen', 'pounds'].includes(currency));

convertCurrency(euros, currency);
