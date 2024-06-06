import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListaTareasComponent } from './lista-tareas/lista-tareas.component';
import { FormularioTareaComponent } from './formulario-tarea/formulario-tarea.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

// Declaramos la interface para tarea
export interface Tarea {
  titulo: string;
  descripcion: string;
  isChecked: boolean;
}

@NgModule({
  declarations: [ListaTareasComponent, FormularioTareaComponent],
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  exports: [ListaTareasComponent, FormularioTareaComponent],
})
export class TareasModule {}
