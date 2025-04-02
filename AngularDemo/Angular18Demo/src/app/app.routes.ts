import { Routes } from '@angular/router';
import { register } from 'module';
import { RegisterComponent } from './components/register/register.component';
import { LoginComponent } from './components/login/login.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { UserdashboardComponent } from './components/userdashboard/userdashboard.component';
import { authGuard } from './auth.guard';
import { LogoutComponent } from './components/logout/logout.component';
import {provideRouter } from '@angular/router';

export const routes: Routes = [
    //  {
    //     path:'header',loadComponent:()=>import('./header.component').then(m=>m.HeaderComponent),
    //  }
    
    {path:'register',component:RegisterComponent},
    {path:'login',component:LoginComponent},
    {path:'dashBoard',component:DashboardComponent },
    {path:'logout',component:LogoutComponent },
    // {path:'userdashboard',component:UserdashboardComponent,canActivate:[authGuard] },
    {path:'userdashboard',component:UserdashboardComponent}
];
