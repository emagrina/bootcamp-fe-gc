import { Component } from '@angular/core';
import database from '@data/database.json';


@Component({
  selector: 'app-characters-page',
  templateUrl: './characters-page.component.html',
  styleUrls: ['./characters-page.component.css']
})
export class CharactersPageComponent {
  characters: any[] = database.characters;
}
