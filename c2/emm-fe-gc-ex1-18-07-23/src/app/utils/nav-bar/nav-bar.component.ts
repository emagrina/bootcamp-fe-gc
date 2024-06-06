import { Component } from '@angular/core';
import { PokemonService } from '../../services/pokemon.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css'],
})
export class NavBarComponent {
  searchPokemon: string = '';

  constructor(private pokemonService: PokemonService, private router: Router) {}

  onSearch() {
    if (this.searchPokemon.trim() !== '') {
      this.pokemonService.getPokemonByName(this.searchPokemon.toLowerCase())
        .subscribe(
          (response: any) => {
            const pokemonId = response.id;
            this.router.navigateByUrl(`/pokemons/${pokemonId}`);
          },
          (error) => {
            console.error('Error:', error);
          }
        );
    }
  }
}
