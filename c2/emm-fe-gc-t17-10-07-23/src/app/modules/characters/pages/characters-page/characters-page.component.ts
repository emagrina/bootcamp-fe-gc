import { Component, OnInit } from '@angular/core';
import { CharactersService } from '../../services/characters-service/characters.service';

@Component({
  selector: 'app-characters-page',
  templateUrl: './characters-page.component.html',
  styleUrls: ['./characters-page.component.css']
})
export class CharactersPageComponent implements OnInit {
  characters: any[] = [];
  sortOrder: string = '';

  constructor(private charactersService: CharactersService) {}

  ngOnInit() {
    this.getCharacters();
  }

  getCharacters() {
    this.charactersService.getCharacters()
      .subscribe(
        (response) => {
          this.characters = response;
        },
        (error) => {
          console.log('Error:', error);
        }
      );
  }
  
}
