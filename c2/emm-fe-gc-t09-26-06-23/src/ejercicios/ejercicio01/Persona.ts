type Sexo = 'H' | 'M';

const defaultSexo = 'H';

class Persona {
  private nombre: string;
  private edad: number;
  private DNI: string;
  private sexo: Sexo;
  private peso: number;
  private altura: number;

  constructor(
    nombre: string = '',
    edad: number = 0,
    DNI: string,
    sexo: Sexo = defaultSexo,
    peso: number = 0,
    altura: number = 0
  ) {
    this.nombre = nombre;
    this.edad = edad;
    this.DNI = DNI;
    this.sexo = sexo;
    this.peso = peso;
    this.altura = altura;
  }
}

const persona1 = new Persona('Juan Pérez', 25, '123456789', 'H', 70, 175);
const persona2 = new Persona('María López', 30, '987654321', 'M', 60, 160);
const persona3 = new Persona('Carlos Gómez', 40, '456789123', 'H', 80, 180);

console.log(persona1, persona2, persona3);
