import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalhaComponent } from './detalha.component';

describe('DetalhaComponent', () => {
  let component: DetalhaComponent;
  let fixture: ComponentFixture<DetalhaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DetalhaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DetalhaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
