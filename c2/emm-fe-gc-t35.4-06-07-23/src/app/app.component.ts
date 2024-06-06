import { Component } from '@angular/core';
import { Tarea } from './tareas/tareas.module';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'emm-fe-gc-t35.4-06-07-23';

  // Crearemos el array donde se almacenaran todas las tareas
  listaTareas: Tarea[] = [
    {
      titulo: 'Deberes',
      descripcion: 'Los deberes del bootcamp 🙈',
      isChecked: false,
    },
    {
      titulo: 'Perro 🐶',
      descripcion: 'Sacar el perro a pasear',
      isChecked: true,
    },
  ];

  /**
   * Obtendremos los datos pasados del formulario en objeto y los pushearemos al array listaTateas
   * @param tarea
   */
  agregarTarea(tarea: Tarea) {
    this.listaTareas.push(tarea);
  }

  /**
   * Eliminaremos la tarea del array existente
   * @param tarea
   */
  eliminarTarea(tarea: Tarea) {
    const index = this.listaTareas.indexOf(tarea);
    if (index !== -1) {
      this.listaTareas.splice(index, 1);
    }
  }
}
