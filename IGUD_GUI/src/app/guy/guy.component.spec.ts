import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GuyComponent } from './guy.component';

describe('GuyComponent', () => {
  let component: GuyComponent;
  let fixture: ComponentFixture<GuyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GuyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
