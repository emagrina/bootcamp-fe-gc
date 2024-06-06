const defaultCarga = 5;

class Lavadora extends Electrodomestico {
  private carga: number;

  constructor(newConsumo: string, newColor: string) {
    super(newConsumo, newColor);
    this.carga = defaultCarga;
  }

  getCarga(): number {
    return this.carga;
  }

  precioFinal(): number {
    let precioTotal = super.precioFinal();

    if (this.carga > 30) {
      precioTotal += 50;
    }

    return precioTotal;
  }
}
