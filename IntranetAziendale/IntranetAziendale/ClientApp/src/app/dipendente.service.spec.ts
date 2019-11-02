import { TestBed, inject } from '@angular/core/testing';

import { DipendenteService } from './dipendente.service';

describe('DipendenteService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DipendenteService]
    });
  });

  it('should be created', inject([DipendenteService], (service: DipendenteService) => {
    expect(service).toBeTruthy();
  }));
});
