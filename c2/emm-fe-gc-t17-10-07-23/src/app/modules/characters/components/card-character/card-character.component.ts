import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-card-character',
  templateUrl: './card-character.component.html',
  styleUrls: ['./card-character.component.css'],
})
export class CardCharacterComponent {
  @Input() character: any;

  isImageLoaded: boolean = false;

  handleImageLoad() {
    this.isImageLoaded = true;
  }
}
