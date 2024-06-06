import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-card-pokemons',
  templateUrl: './card-pokemons.component.html',
  styleUrls: ['./card-pokemons.component.css']
})
export class CardPokemonsComponent {
  @Input() pokemon!: any;
}
