export type CharacterStatus = 'Alive' | 'Dead' | 'unknown';
export type CharacterGender = 'Female' | 'Male' | 'Genderless' | 'unknown';

export class CharacterModel {
  id: number | null = null;
  name: string = '';
  status: CharacterStatus = 'unknown';
  gender: CharacterGender = 'unknown';
  species: string = '';
  origin: string = '';
  location: string = '';
  image: string = '';
  created: string = new Date().toISOString();
}
