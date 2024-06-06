import { Component } from '@angular/core';

@Component({
  selector: 'app-about-page',
  templateUrl: './about-page.component.html',
  styleUrls: ['./about-page.component.css']
})
export class AboutPageComponent {
  imageUrl: string;

  constructor() {
    this.imageUrl = 'https://avatars.githubusercontent.com/u/94017645?v=4';
  }
}
