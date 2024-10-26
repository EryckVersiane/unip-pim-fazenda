import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletaComponent } from './deleta.component';

describe('DeletaComponent', () => {
  let component: DeletaComponent;
  let fixture: ComponentFixture<DeletaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DeletaComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeletaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
