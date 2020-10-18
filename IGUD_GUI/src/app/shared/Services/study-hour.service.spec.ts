import { TestBed } from '@angular/core/testing';

import { StudyHourService } from './study-hour.service';

describe('StudyHourService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StudyHourService = TestBed.get(StudyHourService);
    expect(service).toBeTruthy();
  });
});
