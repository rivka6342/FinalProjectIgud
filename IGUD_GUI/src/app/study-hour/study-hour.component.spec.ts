import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StudyHourComponent } from './study-hour.component';

describe('StudyHourComponent', () => {
  let component: StudyHourComponent;
  let fixture: ComponentFixture<StudyHourComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StudyHourComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StudyHourComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
