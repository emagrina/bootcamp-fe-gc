import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { PokemonsComponent } from './pokemons/pokemons.component';
import { PokemonDetailComponent } from './pokemon-detail/pokemon-detail.component';
import { AboutComponent } from './about/about.component';
import { UtilsModule } from '../utils';
import { CardPokemonsComponent } from './pokemons/components/card-pokemons/card-pokemons.component';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    LoginComponent,
    HomeComponent,
    PokemonsComponent,
    PokemonDetailComponent,
    AboutComponent,
    CardPokemonsComponent
  ],
  imports: [
    CommonModule,
    UtilsModule,
    HttpClientModule,
    RouterModule
  ]
})
export class ModulesModule { }
