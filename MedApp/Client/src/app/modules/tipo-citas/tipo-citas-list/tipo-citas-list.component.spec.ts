import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoCitasListComponent } from './tipo-citas-list.component';

describe('TipoCitasListComponent', () => {
  let component: TipoCitasListComponent;
  let fixture: ComponentFixture<TipoCitasListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TipoCitasListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TipoCitasListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
