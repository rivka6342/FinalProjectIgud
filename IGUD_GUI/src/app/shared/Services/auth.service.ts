import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router'
import { UserService } from './user.service';
import { User } from '../Entities/User';

@Injectable({ providedIn: 'root' })
export class AuthService {
  private key: string;
  private current_user: User;
  private id: string;
  constructor(private httpClient: HttpClient, private router: Router, private userService: UserService) {
    var pass = JSON.parse(localStorage.getItem(this.key));
    this.login(pass.Password);
  }

  login(Password) {
    let user = { 'Password': Password };
    this.httpClient.post<any>(`${environment.apiUrl}User/Login`, user)
      .subscribe((User) => {
        this.current_user = User;
        this.id = user.Password;
        localStorage.setItem(this.key, JSON.stringify(user));
        this.router.navigate(['/']);
      },
        (error: any) => {
          console.log('error', error);
        })

    console.log(Password);
  }
  logout() {
    localStorage.removeItem(this.key);
    this.router.navigate(['/login']);
  }
  currentuser() {
    console.log(this.key)
    return localStorage.getItem(this.key);
  }
  typecurrentuser() {

    return this.current_user ? this.current_user.UserType : undefined;
  }
  //   private httpClient:HttpClient;
}