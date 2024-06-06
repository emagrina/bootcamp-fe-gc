import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientesModule } from './clientes/clientes.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ListadoClienteComponent } from './clientes/listado-cliente/listado-cliente.component';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    ClientesModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
