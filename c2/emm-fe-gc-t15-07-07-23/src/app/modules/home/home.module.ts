import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { SharedModule } from '@shared/shared.module';

import { HomeLayoutComponent } from './pages/home-layout/home-layout.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { CharactersPageComponent } from './pages/characters-page/characters-page.component';
import { AboutPageComponent } from './pages/about-page/about-page.component';
import { DetallePageComponent } from './pages/detalle-page/detalle-page.component';

@NgModule({
  declarations: [
    HomeLayoutComponent,
    HomePageComponent,
    CharactersPageComponent,
    AboutPageComponent,
    DetallePageComponent,
  ],
  imports: [CommonModule, RouterModule, SharedModule],
  exports: [
    HomeLayoutComponent,
    HomePageComponent,
    CharactersPageComponent,
    AboutPageComponent,
    DetallePageComponent,
  ],
})
export class HomeModule {}
