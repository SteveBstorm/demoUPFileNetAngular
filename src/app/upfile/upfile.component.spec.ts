import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpfileComponent } from './upfile.component';

describe('UpfileComponent', () => {
  let component: UpfileComponent;
  let fixture: ComponentFixture<UpfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpfileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
