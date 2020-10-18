import { TestBed } from '@angular/core/testing';

import { GuyService } from './guy.service';

describe('GuyService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GuyService = TestBed.get(GuyService);
    expect(service).toBeTruthy();
  });
});
