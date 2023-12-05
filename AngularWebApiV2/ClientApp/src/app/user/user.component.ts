import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'] 
})
export class UserComponent {
  users!: User[];
  httpClient!: HttpClient;
  baseUrl!: string;
  userId!: string;
  postId!: string;
  postName!: string;
  postEmail!: string;
  postContact!: string;
  postAccount!: string;


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      this.httpClient = http;
      this.baseUrl = baseUrl;
  }

  getAllUsers() {
      this.httpClient.get<User[]>(this.baseUrl + 'api/User/GetAllUsers').subscribe(result => {
        this.users = result;
      }, error => console.error(error));
  }

  getUser() {
    this.httpClient.get<User>(this.baseUrl + `api/User/GetUser/?id=${this.userId}`).subscribe(result => {
      this.users = [result];
    }, error => console.error(error));
  }

  postUser() {
    let user = {
      id: this.postId,
      name: this.postName,
      email: this.postEmail,
      contactId: this.postContact,
      accountId: this.postAccount
    };

    this.httpClient.put<number>(this.baseUrl + 'api/User/PostUser', user).subscribe(result => {
      console.log(`Number of rows edited: ${result}`);
    }, error => console.error(error));
  }

  deactivateUser() {
    this.httpClient.patch<boolean>(this.baseUrl + `api/User/DeactivateUser/?id=${this.userId}`, "").subscribe(result => {
      console.log(`User deactivated: ${result}`);
    }, error => console.error(error));
  }

  activateUser() {
    this.httpClient.patch<boolean>(this.baseUrl + `api/User/ActivateUser/?id=${this.userId}`, "").subscribe(result => {
      console.log(`User activated: ${result}`);
    }, error => console.error(error));
  }

}

interface User {
  id: string;
  name: number;
}

