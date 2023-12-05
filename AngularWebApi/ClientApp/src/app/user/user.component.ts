import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'] 
})
export class UserComponent {
  users!: User[];

  constructor(http: HttpClient, ) {
    http.get<User[]>('api/User/GetAllUsers').subscribe(result => {
      this.users = result;
    }, error => console.error(error));  
  }
}

interface User {
  id: string;
  name: number;
}

