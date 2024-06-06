import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Cliente } from '../clientes.module';

@Component({
  selector: 'app-listado-cliente',
  templateUrl: './listado-cliente.component.html',
  styleUrls: ['./listado-cliente.component.css'],
})
export class ListadoClienteComponent {
  @Input() clientes: Cliente[] = [];
  @Output() clienteEliminado: EventEmitter<Cliente> = new EventEmitter<Cliente>();

  borrarCliente(cliente: Cliente) {
    this.clienteEliminado.emit(cliente);
  }
}
