import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private http: HttpClient) { }

  getAllUsers(baseUrl: string) {
    return this.http.get<User[]>(baseUrl + 'api/User/GetAllUsers');
  }

  getUser(baseUrl: string, userId: string) {
    return this.http.get<User>(baseUrl + `api/User/GetUser/?id=${userId}`);
  }

  postUser(baseUrl: string, user: any[]) {
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
      }
    }

    return this.http.put<number>(baseUrl + 'api/User/PostUser?' + params, user);
  }

  deactivateUser(baseUrl: string, userId: string) {
    return this.http.patch<boolean>(baseUrl + `api/User/DeactivateUser/?id=${userId}`, "");
  }

  activateUser(baseUrl: string, userId: string) {
    return this.http.patch<boolean>(baseUrl + `api/User/ActivateUser/?id=${userId}`, "");
  }
}
interface User {
  id: string;
  name: number;
}
