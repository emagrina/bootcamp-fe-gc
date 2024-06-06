import { Component, Input } from '@angular/core';
import { FormularioContacto } from '../../app.component';

@Component({
  selector: 'app-form-view',
  templateUrl: './form-view.component.html',
  styleUrls: ['./form-view.component.css']
})
export class FormViewComponent {
  @Input() formulario: FormularioContacto = {
    nombre: '',
    email: '',
    mensaje: '',
    respuesta: ''
  };

  @Input() numero1: number | null = null;
  @Input() numero2: number | null = null;

  constructor() {}

}
