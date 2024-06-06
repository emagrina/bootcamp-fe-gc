import { Component } from '@angular/core';

interface Articulo {
  codigo: number;
  descripcion: string;
  precio: number;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'emm-fe-gc-t35.3-06-07-23';

  articulos: Articulo[] = [
    { codigo: 1, descripcion: 'papas', precio: 10.55 },
    { codigo: 2, descripcion: 'manzanas', precio: 12.1 },
    { codigo: 3, descripcion: 'melon', precio: 52.3 },
    { codigo: 4, descripcion: 'cebollas', precio: 17 },
    { codigo: 5, descripcion: 'calabaza', precio: 20 },
  ];

  nuevoArticulo: Articulo = {
    codigo: 0,
    descripcion: '',
    precio: 0,
  };

  articuloSeleccionado: Articulo | null = null;

  agregarArticulo() {
    this.articulos.push({ ...this.nuevoArticulo });
    this.nuevoArticulo.codigo = 0;
    this.nuevoArticulo.descripcion = '';
    this.nuevoArticulo.precio = 0;
  }

  eliminarArticulo(articulo: Articulo) {
    const index = this.articulos.indexOf(articulo);
    if (index !== -1) {
      this.articulos.splice(index, 1);
    }
  }

  seleccionarArticulo(articulo: Articulo) {
    this.articuloSeleccionado = articulo;
    this.nuevoArticulo = { ...articulo };
  }

  modificarArticulo() {
    if (this.articuloSeleccionado) {
      // Actualizar los datos del artículo seleccionado
      this.articuloSeleccionado.codigo = this.nuevoArticulo.codigo;
      this.articuloSeleccionado.descripcion = this.nuevoArticulo.descripcion;
      this.articuloSeleccionado.precio = this.nuevoArticulo.precio;
      this.articuloSeleccionado = null;
      this.nuevoArticulo = { codigo: 0, descripcion: '', precio: 0 };
    }
  }
}
