import { TestBed } from '@angular/core/testing';

import { SignActivityService } from './sign-activity.service';

describe('SignActivityService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SignActivityService = TestBed.get(SignActivityService);
    expect(service).toBeTruthy();
  });
});
