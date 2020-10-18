import { TestBed } from '@angular/core/testing';

import { SignStudyHourService } from './sign-study-hour.service';

describe('SignStudyHourService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SignStudyHourService = TestBed.get(SignStudyHourService);
    expect(service).toBeTruthy();
  });
});
