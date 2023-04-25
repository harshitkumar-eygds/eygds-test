import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HerocomponentComponent } from './herocomponent.component';

describe('HerocomponentComponent', () => {
  let component: HerocomponentComponent;
  let fixture: ComponentFixture<HerocomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HerocomponentComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HerocomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
