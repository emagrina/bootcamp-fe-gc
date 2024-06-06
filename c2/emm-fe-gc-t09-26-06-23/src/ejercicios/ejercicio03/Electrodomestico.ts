type Color = 'blanco' | 'negro' | 'rojo' | 'azul' | 'gris';
type Letras = 'A' | 'B' | 'C' | 'D' | 'E' | 'F';

const defaultPrecioBase = 100;
const defaultColor = 'blanco';
const defaultConsumoEnergetico = 'F';
const defaultPeso = 5;

class Electrodomestico {
  private precioBase: number;
  private color: Color;
  private consumoEnergetico: Letras;
  private peso: number;

  constructor(newConsumo: string, newColor: string) {
    this.precioBase = defaultPrecioBase;
    this.color = this.comprobarColor(newColor);
    this.consumoEnergetico = this.comprobarConsumoEnergetico(newConsumo);
    this.peso = defaultPeso;
  }

  getPrecioBase(): number {
    return this.precioBase;
  }

  getColor(): Color {
    return this.color;
  }

  setColor(valor: Color) {
    this.color = valor;
  }

  getConsumoEnergetico(): Letras {
    return this.consumoEnergetico;
  }

  setConsumoEnergetico(valor: Letras) {
    this.consumoEnergetico = valor;
  }

  getPeso(): number {
    return this.peso;
  }

  comprobarConsumoEnergetico(newLetra: string): Letras {
    switch (newLetra) {
      case 'A':
        return 'A';
      case 'B':
        return 'B';
      case 'C':
        return 'C';
      case 'D':
        return 'D';
      case 'E':
        return 'E';
      case 'F':
        return 'F';
      default:
        return defaultConsumoEnergetico;
    }
  }

  comprobarColor(newColor: string): Color {
    switch (newColor) {
      case 'blanco':
        return 'blanco';
      case 'negro':
        return 'negro';
      case 'rojo':
        return 'rojo';
      case 'azul':
        return 'azul';
      case 'gris':
        return 'gris';
      default:
        return defaultColor;
    }
  }

  precioFinal(): number {
    let precioTotal: number = defaultPrecioBase;
    switch (this.consumoEnergetico) {
      case 'A':
        precioTotal = precioTotal + 100;
        break;
      case 'B':
        precioTotal += 80;
        break;
      case 'C':
        precioTotal += 60;
        break;
      case 'D':
        precioTotal += 50;
        break;
      case 'E':
        precioTotal += 30;
        break;
      case 'F':
        precioTotal += 10;
        break;
    }

    if (this.peso > 0 && this.peso <= 19) {
      precioTotal += 10;
    } else if (this.peso >= 20 && this.peso <= 49) {
      precioTotal += 50;
    } else if (this.peso >= 50 && this.peso <= 79) {
      precioTotal += 80;
    } else if (this.peso >= 80) {
      precioTotal += 100;
    }

    return precioTotal;
  }
}
