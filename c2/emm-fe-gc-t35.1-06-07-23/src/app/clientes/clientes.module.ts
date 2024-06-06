import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListadoClienteComponent } from './listado-cliente/listado-cliente.component';

export interface Cliente {
  nombre: string;
  cif: string;
  direccion: string;
  grupo: string;
}

@NgModule({
  declarations: [
    ListadoClienteComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ListadoClienteComponent,
  ]
})
export class ClientesModule { }
