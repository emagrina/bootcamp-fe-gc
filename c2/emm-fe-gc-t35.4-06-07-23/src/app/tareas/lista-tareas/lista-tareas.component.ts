import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Tarea } from '../tareas.module';

@Component({
  selector: 'app-lista-tareas',
  templateUrl: './lista-tareas.component.html',
  styleUrls: ['./lista-tareas.component.css'],
})
export class ListaTareasComponent {
  // Con Input recibimos la lista de tareas para poderla imprimir y con
  // Output le estamos pasando que tarea tiene que eliminar
  @Input() tareas: Tarea[];
  @Output() tareaEliminada: EventEmitter<Tarea> = new EventEmitter();

  constructor() {
    this.tareas = [];
  }

  /**
   * Pasaremos del componente hijo al padre la tarea que selecionamos para borrar
   * @param tarea
   */
  eliminarTarea(tarea: Tarea) {
    this.tareaEliminada.emit(tarea);
  }

  /**
   * Cambiamos el estado de el check, cada vez que pulsas va cambiando los estilos
   * @param tarea
   */
  cambiarEstadoTarea(tarea: Tarea) {
    tarea.isChecked = tarea.isChecked ? false : true;
  }
}
