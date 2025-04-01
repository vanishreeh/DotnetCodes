import { Component, OnInit } from '@angular/core';
import { BooksService } from '../../services/books.service';
import { Book } from '../../models/book';
import {MatTabsModule} from '@angular/material/tabs';
import { DisplayhorizontalComponent } from './displayhorizontal/displayhorizontal.component';

@Component({
  selector: 'app-getbooks',
  standalone: true,
  imports: [MatTabsModule,DisplayhorizontalComponent],
  templateUrl: './getbooks.component.html',
  styleUrl: './getbooks.component.css'
})
export class GetbooksComponent implements OnInit {
  books:Book[]=[]
constructor(private bookService:BooksService){}
ngOnInit(){
this.getBooks();
}
  getBooks() {
    this.bookService.getBooks().subscribe(data=>{
      this.books=data;
      console.log(this.books);
      
    })
  }
}
