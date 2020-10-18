import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GuyAddComponent } from './guy-add.component';

describe('GuyAddComponent', () => {
  let component: GuyAddComponent;
  let fixture: ComponentFixture<GuyAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GuyAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuyAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
