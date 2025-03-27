 import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import{FormsModule } from '@angular/forms'
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product';
import { log } from 'console';
@Component({
  selector: 'app-product',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent  implements OnInit{
  //#region databinding
// productName:string="TV";
// inputType="text";
// addProduct(msg:string){
//   alert(msg)
// }

// displayMsg=true;

// products=['TV','Mobile','Laptop']
//#endregion
//products:any;
products?:Product[];
newProduct: Product = new Product();
constructor(private productService:ProductService)//before angular 18th 
{
  console.log("this is productcomponent constructor");
  
 }
 ngOnInit():void{
  console.log("this is nogonit method");
  this.getAllProducts();
    
  }
  getAllProducts():void {
    this.productService.getAllProducts().subscribe(res=>{
      console.log(res);
      this.products=res;
      }
    )
  }


  addProduct():void{
    this.productService.addProduct(this.newProduct).subscribe(res=>{
      console.log(res);
      this.products?.push(res);
    })
  }
  updateProduct(product:Product):void{
this.productService.updateProduct(product).subscribe(res=>{
  console.log(res);
this.getAllProducts();
})
  
 }

}
