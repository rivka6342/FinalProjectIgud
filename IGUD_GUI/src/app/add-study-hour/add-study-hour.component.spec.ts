import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddStudyHourComponent } from './add-study-hour.component';

describe('AddStudyHourComponent', () => {
  let component: AddStudyHourComponent;
  let fixture: ComponentFixture<AddStudyHourComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddStudyHourComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddStudyHourComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
