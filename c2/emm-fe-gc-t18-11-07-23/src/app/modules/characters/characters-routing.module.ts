import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CharactersPageComponent } from './pages/characters-page/characters-page.component';
import { DetallePageComponent } from './pages/detalle-page/detalle-page.component';

const routes: Routes = [
  { path: '', component: CharactersPageComponent },
  { path: ':id', component: DetallePageComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CharactersRoutingModule { }
