import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoCitasDetailComponent } from './tipo-citas-detail.component';

describe('TipoCitasDetailComponent', () => {
  let component: TipoCitasDetailComponent;
  let fixture: ComponentFixture<TipoCitasDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TipoCitasDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TipoCitasDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
