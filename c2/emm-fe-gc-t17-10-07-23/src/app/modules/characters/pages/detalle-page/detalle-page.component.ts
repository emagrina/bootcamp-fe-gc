import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DetalleService } from '../../services/detalle-service/detalle.service';

@Component({
  selector: 'app-detalle-page',
  templateUrl: './detalle-page.component.html',
  styleUrls: ['./detalle-page.component.css'],
})
export class DetallePageComponent implements OnInit {
  characterId: string = '';
  character: any;

  constructor(private route: ActivatedRoute, private detalleService: DetalleService) {}

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.characterId = params['id'];

      this.getCharacter(this.characterId);
    });
  }

  getCharacter(id: string) {
    this.detalleService.getCharacter(id)
      .subscribe(
        (response) => {
          this.character = response;
        },
        (error) => {
          console.log('Error:', error);
        }
      );
  }
}
