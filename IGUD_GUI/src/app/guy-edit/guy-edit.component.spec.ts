import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GuyEditComponent } from './guy-edit.component';

describe('GuyEditComponent', () => {
  let component: GuyEditComponent;
  let fixture: ComponentFixture<GuyEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GuyEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuyEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
