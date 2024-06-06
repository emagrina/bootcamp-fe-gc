import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateEditFormComponent } from './create-edit-form.component';

describe('CreateEditFormComponent', () => {
  let component: CreateEditFormComponent;
  let fixture: ComponentFixture<CreateEditFormComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CreateEditFormComponent]
    });
    fixture = TestBed.createComponent(CreateEditFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
