import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DetalleService {
  constructor(private http: HttpClient) {}

  getCharacter(id: string) {
    return this.http.get<any>(`https://rickandmortyapi.com/api/character/${id}`);
  }
}
