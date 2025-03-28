import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AuthResponseModel, Login } from '../models/login';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl="https://localhost:7134/api/Auth";
//https://localhost:7134/api/Auth/login
//https://localhost:7134/api/Auth/register
  constructor(private http:HttpClient) { }

  login(loginData:Login):Observable<AuthResponseModel>{
    return this.http.post<AuthResponseModel>(`${this.apiUrl}/login`,loginData)
  }
}
