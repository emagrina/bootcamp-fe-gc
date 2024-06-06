class MainApp {
  constructor() {
    const electrodomesticos: Electrodomestico[] = [];

    electrodomesticos[0] = new Lavadora('A', 'blanco');
    electrodomesticos[1] = new Television('B', 'negro');
    electrodomesticos[2] = new Electrodomestico('C', 'rojo');
    electrodomesticos[3] = new Lavadora('D', 'azul');
    electrodomesticos[4] = new Television('E', 'gris');
    electrodomesticos[5] = new Electrodomestico('F', 'blanco');
    electrodomesticos[6] = new Lavadora('A', 'negro');
    electrodomesticos[7] = new Television('B', 'rojo');
    electrodomesticos[8] = new Electrodomestico('C', 'azul');
    electrodomesticos[9] = new Lavadora('D', 'gris');

    let precioTotalElectrodomesticos = 0;
    let precioTotalLavadoras = 0;
    let precioTotalTelevisores = 0;

    for (const electrodomestico of electrodomesticos) {
      const precioFinal = electrodomestico.precioFinal();
      precioTotalElectrodomesticos += precioFinal;

      if (electrodomestico instanceof Lavadora) {
        precioTotalLavadoras += precioFinal;
      }

      if (electrodomestico instanceof Television) {
        precioTotalTelevisores += precioFinal;
      }
    }

    console.log(
      'Precio total electrodomésticos:',
      precioTotalElectrodomesticos
    );
    console.log('Precio total lavadoras:', precioTotalLavadoras);
    console.log('Precio total televisores:', precioTotalTelevisores);
  }
}

new MainApp();
