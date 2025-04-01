import { Component } from '@angular/core';
import { Book } from '../../models/book';
import { BooksService } from '../../services/books.service';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
books:Book[]=[];
displayEmail?:string|null
constructor(private bookService:BooksService){}
ngOnInit(){
  this.displayEmail=localStorage.getItem('email');
  this.getAllBooks();

}
  getAllBooks() {
   this.bookService.getBooks().subscribe(data=>{
    console.log(data);
    this.books=data;
    
   })
  }

}
