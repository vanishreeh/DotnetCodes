import { Component, OnInit } from '@angular/core';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatSelectModule} from '@angular/material/select';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatButtonModule} from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product';

@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [MatExpansionModule,MatFormFieldModule, MatInputModule, MatSelectModule,MatButtonModule,FormsModule],
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent implements OnInit {
  newProduct: Product = new Product();
  products?:Product[];
  constructor(private productService:ProductService) { }

  ngOnInit(): void {
   this.addProduct();
  }
  addProduct():void{
    this.productService.addProduct(this.newProduct).subscribe(res=>{
      console.log(res);
      this.products?.push(res);
    })
  }
}
