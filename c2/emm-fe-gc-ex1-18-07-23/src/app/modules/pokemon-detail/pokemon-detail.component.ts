import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PokemonService } from 'src/app/services/pokemon.service';

@Component({
  selector: 'app-pokemon-detail',
  templateUrl: './pokemon-detail.component.html',
  styleUrls: ['./pokemon-detail.component.css']
})
export class PokemonDetailComponent implements OnInit{
  pokemonId!: number;
  pokemon!: any;

  constructor(
    private route: ActivatedRoute,
    private pokemonService: PokemonService,
  ) {
  }

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.pokemonId = params['id'];

      this.getPokemon(this.pokemonId);
    });
  }

  getPokemon(id: number) {
    this.pokemonService.getPokemonById(id).subscribe(
      (response) => {
        this.pokemon = {
          id: response.id,
          name: response.name,
          baseImg: response.sprites.front_default,
          version: `Generation ${this.determineGeneration(response.id)}`,
          abilities: response.abilities
        };
        console.log(response);

      },
      (error) => {
        console.error('Error:', error);
      },
    );


  }
  determineGeneration(pokemonId: number) {
    if (pokemonId <= 151) {
      return 1;
    } else if (pokemonId <= 251) {
      return 2;
    } else if (pokemonId <= 386) {
      return 3;
    } else if (pokemonId <= 493) {
      return 4;
    } else if (pokemonId <= 649) {
      return 5;
    } else if (pokemonId <= 721) {
      return 6;
    } else if (pokemonId <= 809) {
      return 7;
    } else {
      return 8;
    }
  }


}
