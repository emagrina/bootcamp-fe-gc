import { Component, Input, EventEmitter, Output } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-modal-layout',
  templateUrl: './modal-layout.component.html',
  styleUrls: ['./modal-layout.component.css'],
})
export class ModalLayoutComponent {
  @Input() modalTitle!: 'Edit Character' | 'Create Character';
  @Input() isModalOpen = false;
  @Output() modalClosed: EventEmitter<void> = new EventEmitter<void>();

  private previousUrl: string | null = null;

  constructor(private location: Location) {}

  /**
   * Modificamos la url con el titulo que le pasamos por input
   * lo transformamos a kebab case, luego guardamos el path anterior
   * y lo devolvemos al salir del modal
   */
  ngOnChanges() {
    const kebabCaseText = this.toKebabCase(this.modalTitle);

    if (this.isModalOpen) {
      this.location.replaceState(`/characters/${kebabCaseText}`);
    } else {
      if (
        '/characters/edit-character' === this.previousUrl ||
        '/characters/create-character' === this.previousUrl ||
        this.previousUrl === null
      ) {
        this.previousUrl = this.location.path();
      } else {
        this.location.replaceState(this.previousUrl);
      }
      this.modalClosed.emit();
    }
  }

  closeModalManually(): void {
    this.isModalOpen = false;
    this.modalClosed.emit();
  }

  /**
   * Pasaremos el titulo del modal por url, pero antes lo pasaremos a kebab case
   * @param input
   * @returns
   */
  toKebabCase(input: string): string {
    return input
      .toLowerCase()
      .replace(/\s+/g, '-')
      .replace(/[^a-z0-9-]/g, '');
  }
}
