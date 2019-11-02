import { TestBed, inject } from '@angular/core/testing';

import { ConvenzioneService } from './convenzione.service';

describe('ConvenzioneService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ConvenzioneService]
    });
  });

  it('should be created', inject([ConvenzioneService], (service: ConvenzioneService) => {
    expect(service).toBeTruthy();
  }));
});
