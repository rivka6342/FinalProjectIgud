import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SignActivityComponent } from './sign-activity.component';

describe('SignActivityComponent', () => {
  let component: SignActivityComponent;
  let fixture: ComponentFixture<SignActivityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SignActivityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SignActivityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
