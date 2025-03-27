import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private http=inject(HttpClient);//from angular 18

  //constructor(private http:HttpClient) { 

  //}

  getAllProducts():Observable<Product[]>{
    return this.http.get<Product[]>('http://localhost:3000/products')
  }
  addProduct(product: Product): Observable<Product> {
    return this.http.post<Product>('http://localhost:3000/products', product);
 }
 getProductById(id: number): Observable<Product> {
  return this.http.get<Product>(`http://localhost:3000/products/${id}` );
}

updateProduct(product: Product): Observable<Product> {
  return this.http.put<Product>(`http://localhost:3000/products/${product.id}`, product);
}
}
