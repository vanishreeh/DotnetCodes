import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ProductComponent } from './components/product/product.component';
import { AddProductComponent } from './components/add-product/add-product.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { HeaderComponent } from './components/header/header.component';
import { GetbooksComponent } from './components/getbooks/getbooks.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ProductComponent,AddProductComponent,LoginComponent,RegisterComponent,HeaderComponent,GetbooksComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Angular18Demo';
}
