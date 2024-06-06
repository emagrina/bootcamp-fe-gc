class Password {
  private longitud: number;
  private contrasena: string;

  constructor(longitud: number = 8) {
    this.longitud = longitud;
    this.contrasena = this.generarContrasena();
  }

  private generarContrasena(): string {
    const caracteres =
      'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_';
    let contrasena = '';
    for (let i = 0; i < this.longitud; i++) {
      const randomIndex = Math.floor(Math.random() * caracteres.length);
      contrasena += caracteres.charAt(randomIndex);
    }
    return contrasena;
  }
}

const contrasena1 = new Password(20)
const contrasena2 = new Password(10)
const contrasena3 = new Password(5)

console.log(contrasena1, contrasena2, contrasena3);
