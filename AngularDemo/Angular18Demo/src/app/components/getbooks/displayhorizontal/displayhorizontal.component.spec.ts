import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayhorizontalComponent } from './displayhorizontal.component';

describe('DisplayhorizontalComponent', () => {
  let component: DisplayhorizontalComponent;
  let fixture: ComponentFixture<DisplayhorizontalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DisplayhorizontalComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisplayhorizontalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
