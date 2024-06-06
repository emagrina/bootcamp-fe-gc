import { Component, OnInit } from '@angular/core';
import { CharacterService } from '../../services/character.service';

@Component({
  selector: 'app-characters-page',
  templateUrl: './characters-page.component.html',
  styleUrls: ['./characters-page.component.css']
})
export class CharactersPageComponent implements OnInit {
  characters: any[] = [];
  imageUrl: string;
  isModalOpen = false;

  constructor(private characterService: CharacterService) {
    this.imageUrl = '../../../../assets/img/img-inf-new-character.png';
  }

  ngOnInit() {
    this.getCharacters();
  }

  getCharacters() {
    this.characterService.getCharacters()
      .subscribe(
        (response) => {
          this.characters = response;
        },
        (error) => {
          console.error('Error:', error);
        }
      );
  }

  openModal() {
    this.isModalOpen = true;
  }

  closeModal() {
    this.isModalOpen = false;
    this.getCharacters();
  }
}
