import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecommendproductsComponent } from './recommendproducts.component';

describe('RecommendproductsComponent', () => {
  let component: RecommendproductsComponent;
  let fixture: ComponentFixture<RecommendproductsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecommendproductsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RecommendproductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
