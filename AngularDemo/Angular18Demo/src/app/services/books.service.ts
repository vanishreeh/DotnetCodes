import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../models/book';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http:HttpClient) { }
  getBooks():Observable<Book[]>{
    return this.http.get<Book[]>('https://localhost:7134/api/Book')
  }
}
