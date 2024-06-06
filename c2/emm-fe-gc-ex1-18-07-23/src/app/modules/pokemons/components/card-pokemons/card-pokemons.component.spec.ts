import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardPokemonsComponent } from './card-pokemons.component';

describe('CardPokemonsComponent', () => {
  let component: CardPokemonsComponent;
  let fixture: ComponentFixture<CardPokemonsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CardPokemonsComponent]
    });
    fixture = TestBed.createComponent(CardPokemonsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
