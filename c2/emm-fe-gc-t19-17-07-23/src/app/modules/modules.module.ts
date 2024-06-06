import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { UtilsModule } from '@utils/utils.module';
import { HomePageComponent } from './home/pages';
import { CharactersPageComponent, DetallePageComponent } from './characters/pages';
import { CardCharacterComponent, CreateEditFormComponent, ModalLayoutComponent } from './characters/components';
import { AboutPageComponent } from './about';
import { AuthLayoutComponent, LoginPageComponent, RegisterPageComponent } from './auth';

@NgModule({
  declarations: [
    HomePageComponent,
    CharactersPageComponent,
    DetallePageComponent,
    CardCharacterComponent,
    ModalLayoutComponent,
    CreateEditFormComponent,
    AboutPageComponent,
    LoginPageComponent,
    RegisterPageComponent,
    AuthLayoutComponent
  ],
  imports: [
    CommonModule,
    UtilsModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],

})
export class ModulesModule { }
