const defaultResolucion = 20;
const defaultEs4K = false;

class Television extends Electrodomestico {
  private resolucion: number;
  private es4K: boolean;

  constructor(newConsumo: string, newColor: string) {
    super(newConsumo, newColor);
    this.resolucion = defaultResolucion;
    this.es4K = defaultEs4K;
  }

  getResolucion4K(): boolean {
    return this.es4K;
  }

  precioFinal(): number {
    let precioTotal = super.precioFinal();

    if (this.resolucion > 40) {
      precioTotal *= 1.3;
    }

    if (this.es4K) {
      precioTotal += 50;
    }

    return precioTotal;
  }
}
