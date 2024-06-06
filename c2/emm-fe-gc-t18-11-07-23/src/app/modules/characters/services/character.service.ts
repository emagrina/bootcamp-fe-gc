import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '@environments/environment';
import { Observable } from 'rxjs';
import { CharacterModel } from '../models/character.model';

@Injectable({
  providedIn: 'root',
})
export class CharacterService {
  private apiUrl: string;

  constructor(private http: HttpClient) {
    this.apiUrl = environment.apiUrl;
  }

  /**
   * Obtenemos todos los datos de characters
   * @returns
   */
  getCharacters() {
    return this.http.get<CharacterModel[]>(`${this.apiUrl}/characters`);
  }

  /**
   * Obtenemos solo un characacter por id
   * @param id
   * @returns
   */
  getCharacter(id: number | null) {
    return this.http.get<CharacterModel>(`${this.apiUrl}/characters/${id}`);
  }

  /**
   * Creamos un nuevo character
   * @param characterData
   * @returns
   */
  createCharacter(characterData: CharacterModel): Observable<CharacterModel> {
    return this.http.post<CharacterModel>(
      `${this.apiUrl}/characters`,
      characterData
    );
  }

  /**
   * Actualizamos un character por el ID
   * @param characterData
   * @returns
   */
  updateCharacter(characterData: CharacterModel): Observable<CharacterModel> {
    const characterId = characterData.id;

    return this.http.put<CharacterModel>(
      `${this.apiUrl}/characters/${characterId}`,
      characterData
    );
  }

  /**
   * Borrar un character por el ID
   */
  deleteCharacter(characterId: number | null): Observable<CharacterModel> {
    return this.http.delete<CharacterModel>(
      `${this.apiUrl}/characters/${characterId}`
    );
  }
}
