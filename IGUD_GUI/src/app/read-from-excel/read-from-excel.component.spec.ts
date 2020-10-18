import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadFromExcelComponent } from './read-from-excel.component';

describe('ReadFromExcelComponent', () => {
  let component: ReadFromExcelComponent;
  let fixture: ComponentFixture<ReadFromExcelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReadFromExcelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadFromExcelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
