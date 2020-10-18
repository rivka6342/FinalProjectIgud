import { TestBed } from '@angular/core/testing';

import { ReadFromExcelServiceService } from './read-from-excel-service.service';

describe('ReadFromExcelServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ReadFromExcelServiceService = TestBed.get(ReadFromExcelServiceService);
    expect(service).toBeTruthy();
  });
});
