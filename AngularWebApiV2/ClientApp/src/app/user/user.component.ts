import { Component, Inject, NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'],
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
  tabLoadTimes: Date[] = [];

  ngAfterViewInit() {
    console.log("afterinit");
    setTimeout(() => {
      console.log(1);
    }, 1000);
  }

  getTimeLoaded(index: number) {
    if (!this.tabLoadTimes[index]) {
      this.tabLoadTimes[index] = new Date();
    }

    return this.tabLoadTimes[index];
  }

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
    const user = [
      this.postId,
      this.postName,
      this.postEmail,
      this.postContact,
      this.postAccount
    ];

    const paramNames = [
       "id",
       "name",
       "email",
       "contactId",
       "accountId"
    ];
    
    let params = "";
    for (const param in user) {
      if (user[param] != undefined && user[param] != "") {
        params += `&${paramNames[param]}=${user[param]}`
        console.log(`&${paramNames[param]}=${user[param]}`);
      }      
    }

    this.httpClient.put<number>(this.baseUrl + 'api/User/PostUser?' + params, user).subscribe(result => {
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

