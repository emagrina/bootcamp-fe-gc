import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import database from '@data/database.json';

@Component({
  selector: 'app-detalle-page',
  templateUrl: './detalle-page.component.html',
  styleUrls: ['./detalle-page.component.css'],
})
export class DetallePageComponent implements OnInit {
  characterId: string = '';
  character: any;

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.characterId = params['id'];

      this.character = database.characters.find(
        (c) => c.id === parseInt(this.characterId)
      );
    });
  }
}
