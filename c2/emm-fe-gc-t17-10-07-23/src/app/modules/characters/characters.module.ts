import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { SharedModule } from '@shared/shared.module';

import { CharactersPageComponent } from './pages/characters-page/characters-page.component';
import { DetallePageComponent } from './pages/detalle-page/detalle-page.component';
import { CardCharacterComponent } from './components/card-character/card-character.component';

@NgModule({
  declarations: [
    CharactersPageComponent,
    DetallePageComponent,
    CardCharacterComponent,
  ],
  imports: [CommonModule, RouterModule, SharedModule, HttpClientModule],
  exports: [
    CharactersPageComponent,
    DetallePageComponent,
    CardCharacterComponent,
  ],
})
export class CharactersModule {}
