import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { CharactersRoutingModule } from './characters-routing.module';
import { SharedModule } from '@shared/shared.module';

import { CharactersPageComponent, DetallePageComponent } from './pages';
import { CardCharacterComponent, CreateEditFormComponent, ModalLayoutComponent} from './components';

@NgModule({
  declarations: [
    CharactersPageComponent,
    DetallePageComponent,
    CardCharacterComponent,

    ModalLayoutComponent,
    CreateEditFormComponent,
  ],
  imports: [CommonModule, CharactersRoutingModule, SharedModule, HttpClientModule, ReactiveFormsModule],
})
export class CharactersModule {}
