import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { CardCharacterComponent } from './components/card-character/card-character.component';

@NgModule({
  declarations: [
    NavBarComponent,
    CardCharacterComponent,
  ],
  imports: [
    CommonModule,
    RouterModule,
  ],
  exports: [
    NavBarComponent,
    CardCharacterComponent,
  ]
})
export class SharedModule { }
