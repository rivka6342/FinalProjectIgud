import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SignStudyHourComponent } from './sign-study-hour.component';

describe('SignStudyHourComponent', () => {
  let component: SignStudyHourComponent;
  let fixture: ComponentFixture<SignStudyHourComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SignStudyHourComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SignStudyHourComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
