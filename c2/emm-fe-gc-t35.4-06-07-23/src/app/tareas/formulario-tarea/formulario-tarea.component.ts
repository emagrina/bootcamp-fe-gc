import { Component, EventEmitter, Output } from '@angular/core';
import { Tarea } from '../tareas.module';

@Component({
  selector: 'app-formulario-tarea',
  templateUrl: './formulario-tarea.component.html',
  styleUrls: ['./formulario-tarea.component.css'],
})
export class FormularioTareaComponent {
 // Enviaremos la tarea al elemento padre en este caso lo estamos agregando al array existente
  @Output() agregarTarea: EventEmitter<Tarea> = new EventEmitter<Tarea>();

  // Declaramos las variables para recoger los datos del formulario
  tarea: Tarea = {
    titulo: '',
    descripcion: '',
    isChecked: false,
  };

  /**
   * Si es valido lo guarda en agregarTarea que lo manda al componente padre y vacia los campos
   * si esta mal nos mandara un aviso por consola
   */
  guardarTarea() {
    const { titulo, descripcion } = this.tarea;

    if (titulo && descripcion) {
      const nuevaTarea: Tarea = { ...this.tarea };
      this.agregarTarea.emit(nuevaTarea);

      this.tarea = {
        titulo: '',
        descripcion: '',
        isChecked: false,
      };

    } else {
      console.error('Invalid cliente', this.tarea);
    }
  }
}
