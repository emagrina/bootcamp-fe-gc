import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from '@modules/auth/login/login.component';
import { RegisterComponent } from '@modules/auth/register/register.component';
import { AboutPageComponent } from '@modules/home/pages/about-page/about-page.component';
import { CharactersPageComponent } from '@modules/home/pages/characters-page/characters-page.component';
import { DetallePageComponent } from '@modules/home/pages/detalle-page/detalle-page.component';
import { HomePageComponent } from '@modules/home/pages/home-page/home-page.component';

const routes: Routes = [
  { path: 'auth/login', component: LoginComponent },
  { path: 'auth/register', component: RegisterComponent },
  { path: 'login', redirectTo: 'auth/login', pathMatch: 'full' },
  { path: 'register', redirectTo: 'auth/register', pathMatch: 'full' },
  { path: '', component: HomePageComponent },
  { path: 'characters', component: CharactersPageComponent },
  { path: 'about', component: AboutPageComponent },
  { path: 'characters/character/:id', component: DetallePageComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
