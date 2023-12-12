import { Component, Inject, NgModule } from '@angular/core';
import { UserService } from './user.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css'],
})

export class UserComponent {
  users!: User[];
  baseUrl!: string;
  userId!: string;
  postId!: string;
  postName!: string;
  postEmail!: string;
  postContact!: string;
  postAccount!: string;
  tabLoadTimes: Date[] = [];

  constructor(private userService: UserService, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getAllUsers() {
    this.userService.getAllUsers(this.baseUrl).subscribe(result => {
      this.users = result;
    }, error => console.error(error));
  }

  getUser() {
    this.userService.getUser(this.baseUrl, this.userId).subscribe(result => {
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

    this.userService.postUser(this.baseUrl, user).subscribe(result => {
      console.log(`Number of rows edited: ${result}`);
    }, error => console.error(error));
  }

  deactivateUser() {
    this.userService.deactivateUser(this.baseUrl, this.userId).subscribe(result => {
      console.log(`User deactivated: ${result}`);
    }, error => console.error(error));
  }

  activateUser() {
    this.userService.activateUser(this.baseUrl, this.userId).subscribe(result => {
      console.log(`User activated: ${result}`);
    }, error => console.error(error));
  }
}

interface User {
  id: string;
  name: number;
}
