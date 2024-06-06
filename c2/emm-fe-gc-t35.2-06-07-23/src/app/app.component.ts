import { Component, OnInit } from '@angular/core';

export interface FormularioContacto {
  nombre: string;
  email: string;
  mensaje: string;
  respuesta: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'emm-fe-gc-t35.2-06-07-23';

  // Crearemos un objeto con los parametros insertados y
  // otro para controlar que es y que no es valido
  formulario: FormularioContacto = {
    nombre: '',
    email: '',
    mensaje: '',
    respuesta: '',
  };

  formularioValido: { [key: string]: boolean } = {
    nombre: true,
    email: true,
    mensaje: true,
    respuesta: true,
  };

  numero1: number = 0;
  numero2: number = 0;
  suma: number = 0;

  mostramosLosParametros: boolean = false;


  ngOnInit() {
    this.generarNumerosAleatorios();
  }

  submitForm() {
    if (this.isValidForm()) {
      this.mostramosLosParametros = true;
    } else {
      console.error('Invalid form', this.formularioValido);
    }
  }

  isValidForm(): boolean {
    const emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
    const { nombre, email, mensaje, respuesta } = this.formulario;

    this.formularioValido = {
      nombre: nombre.length > 0,
      email: emailRegex.test(email),
      mensaje: mensaje.length >= 5,
      respuesta: parseInt(respuesta) === this.suma,
    };

    return Object.values(this.formularioValido).every((valido) => valido);
  }

  generarNumerosAleatorios() {
    this.numero1 = Math.floor(Math.random() * 10);
    this.numero2 = Math.floor(Math.random() * 10);
    this.suma = this.numero1 + this.numero2;
  }

}
