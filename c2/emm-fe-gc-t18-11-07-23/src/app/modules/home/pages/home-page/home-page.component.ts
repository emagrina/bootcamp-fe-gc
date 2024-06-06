import { Component } from '@angular/core';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent {
  imageUrl: string;

  constructor() {
    this.imageUrl = 'https://areajugones.sport.es/wp-content/uploads/2020/05/RicKMorty.jpg';
  }
}
