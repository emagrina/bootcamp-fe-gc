import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CharacterService } from '../../services/character.service';
import { CharacterModel } from '@modules/characters/models/character.model';

@Component({
  selector: 'app-detalle-page',
  templateUrl: './detalle-page.component.html',
  styleUrls: ['./detalle-page.component.css'],
})
export class DetallePageComponent implements OnInit {
  characterId: number | null = null;
  character!: CharacterModel;
  isModalOpen = false;

  characterImageUrl = 'https://github.com/emagrina/emm-fe-gc-t18-11-07-23/blob/main/src/assets/img/def-img.jpeg?raw=true';
  isLoadingImage = true;

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private characterService: CharacterService,
  ) {
  }

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.characterId = params['id'];

      this.getCharacter(this.characterId);
    });
  }

  getCharacter(id: number | null) {
    this.characterService.getCharacter(id).subscribe(
      (response) => {
        this.character = response;
      },
      (error) => {
        console.log('Error:', error);
      },
    );
  }

  /**
   * Validacion de la imagen para saber si esta rota o no y si cargar una imagen por defecto
   */
  onImageLoad() {
    this.isLoadingImage = false;
  }

  ngOnChanges() {
    this.isLoadingImage = true;
  }

  /**
   * Borarremos un character
   */
  deleteCharacter(characterId: number | null) {
    this.characterService.deleteCharacter(characterId).subscribe(
      () => {
        this.router.navigate(['/characters']);
      },
      (error) => {
        console.error('Error deleting character:', error);
      },
    );
  }

  // Gestionamos el Modal
  openModal() {
    this.isModalOpen = true;
  }

  closeModal() {
    this.isModalOpen = false;
    this.getCharacter(this.characterId);
  }
}
