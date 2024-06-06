import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CharacterService } from '../../services/character.service';
import {
  CharacterModel,
  CharacterStatus,
  CharacterGender,
} from '@modules/characters/models/character.model';

@Component({
  selector: 'app-create-edit-form',
  templateUrl: './create-edit-form.component.html',
  styleUrls: ['./create-edit-form.component.css'],
})
export class CreateEditFormComponent implements OnInit {
  @Input() isEditMode: boolean = false;
  @Input() idCharacter!: number | null;

  // Para gestionar el formilario
  characterForm: FormGroup = this.formBuilder.group({
    id: [null],
    name: ['', Validators.required],
    status: ['unknown', Validators.required],
    gender: ['unknown', Validators.required],
    species: [''],
    origin: [''],
    location: [''],
    image: [''],
    created: [new Date().toISOString()],
  });

  characterStatuses: CharacterStatus[] = ['Alive', 'Dead', 'unknown'];
  characterGenders: CharacterGender[] = [
    'Female',
    'Male',
    'Genderless',
    'unknown',
  ];

  constructor(
    private formBuilder: FormBuilder,
    private characterService: CharacterService
  ) {}

  ngOnInit(): void {
    if (this.isEditMode) {
      this.characterService.getCharacter(this.idCharacter).subscribe(
        (character) => {
          // Patch the form with the character data received for editing
          this.characterForm.patchValue(character);
        },
        (error) => {
          console.error('Error fetching character:', error);
        }
      );
    }
  }

  /**
   * Comprobara si el formulario es valido, luego dependiendo si estamos editando
   * o creando un nuevo character nos hara una cosa u otra
   */
  onSubmit() {
    if (this.characterForm.valid) {
      const characterData: CharacterModel = this.characterForm.value;

      if (this.isEditMode) {
        this.characterService.updateCharacter(characterData).subscribe(
          (error) => {
            console.error('Error updating character:', error);
          }
        );
      } else {
        this.characterService.createCharacter(characterData).subscribe(

          (response) => {
            this.characterForm.reset();
          },
          (error) => {
            console.error('Error creating character:', error);
          }
        );
      }
    }
  }
}
