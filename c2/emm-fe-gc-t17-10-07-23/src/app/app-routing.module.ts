import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LoginPageComponent, RegisterPageComponent } from '@modules/auth/pages';
import { HomePageComponent } from '@modules/home/pages/home-page/home-page.component';
import { CharactersPageComponent, DetallePageComponent } from '@modules/characters/pages';
import { AboutPageComponent } from '@modules/about/pages/about-page/about-page.component';

const routes: Routes = [
  { path: 'auth/login', component: LoginPageComponent },
  { path: 'auth/register', component: RegisterPageComponent },
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
  exports: [RouterModule]
})
export class AppRoutingModule { }
