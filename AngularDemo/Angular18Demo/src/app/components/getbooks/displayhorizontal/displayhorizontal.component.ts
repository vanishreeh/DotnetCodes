import { Component, Input } from '@angular/core';
import { Book } from '../../../models/book';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-displayhorizontal',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './displayhorizontal.component.html',
  styleUrl: './displayhorizontal.component.css'
})
export class DisplayhorizontalComponent {

  @Input ('bookData') public books?:Book[]

}
