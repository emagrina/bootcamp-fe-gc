import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class CharactersService {
  constructor(private http: HttpClient) {}

  getCharacters() {
    const randomIds = Array.from(
      { length: 8 },
      () => Math.floor(Math.random() * 826) + 1
    );
    const idsString = randomIds.join(',');

    return this.http.get<any[]>(
      `https://rickandmortyapi.com/api/character/${idsString}`
    );
  }
}
