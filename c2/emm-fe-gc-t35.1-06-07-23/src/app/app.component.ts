import { Component } from '@angular/core';
import { Cliente } from './clientes/clientes.module';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'emm-fe-gc-t35.1-06-07-23'

  cliente: Cliente = {
    nombre: '',
    cif: '',
    direccion: '',
    grupo: '',
  };

  listaClientes: Cliente[] = [
    {
      nombre: 'Cliente 1',
      cif: 'B 123',
      direccion: 'C/ la la la',
      grupo: '1',
    },
    {
      nombre: 'Cliente 2',
      cif: 'A 334',
      direccion: 'Av. lo lo lo',
      grupo: '2',
    },
  ];

  guardarCliente() {
    const { nombre, cif, direccion, grupo } = this.cliente;

    if (nombre && cif && direccion && grupo) {
      const nuevoCliente: Cliente = { ...this.cliente };
      this.listaClientes.push(nuevoCliente);

      console.log(nuevoCliente);

      this.cliente = {
        nombre: '',
        cif: '',
        direccion: '',
        grupo: '',
      };
    } else {
      console.error('Cliente inválido');
    }
  }

  eliminarCliente(cliente: Cliente) {
    const index = this.listaClientes.indexOf(cliente);
    if (index !== -1) {
      this.listaClientes.splice(index, 1);
    }
  }
}
