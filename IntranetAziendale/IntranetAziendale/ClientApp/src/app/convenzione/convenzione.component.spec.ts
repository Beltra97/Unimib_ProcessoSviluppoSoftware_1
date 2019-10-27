import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConvenzioneComponent } from './convenzione.component';

describe('ConvenzioneComponent', () => {
  let component: ConvenzioneComponent;
  let fixture: ComponentFixture<ConvenzioneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConvenzioneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConvenzioneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
