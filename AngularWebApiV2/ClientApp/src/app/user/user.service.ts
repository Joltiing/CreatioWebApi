import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private http: HttpClient) { }

  onButtonClick() {
    return this.http.get('api/User/GetUsers');
  }

  
}
