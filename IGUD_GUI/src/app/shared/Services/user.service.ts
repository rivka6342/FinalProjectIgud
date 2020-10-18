import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { User, eUserType } from '../Entities/User'
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  UserId: string;
  FirstName: string;
  LastName: string;
  Email: string;
  CommunityId: number;
  UserType: eUserType;
  IsDeleted: boolean;
  DeletionDate: Date;
  BirthDate: Date;
  Phone: string;
  Street: string;
  HouseNumber: number;
  Sector: string;
  CommunityName:string;
  User: User = new User(this.UserId, this.FirstName, this.LastName, this.Email, this.CommunityId, this.UserType, this.IsDeleted, this.DeletionDate, this.BirthDate, this.Phone, this.Street, this.HouseNumber, this.Sector,this.CommunityName);
  Users: User[] = [];

  constructor(private http: HttpClient) { }
  // api='http://localhost:56580/api/User/';

  getUsers() {
    this.http.get<User[]>(environment.apiUrl + 'User/').subscribe(state => { this.Users = state; console.log(this.Users); });
  }


  getUserById(id: string) {
    return this.http.get<User>(`${environment.apiUrl + 'User/'}${id}`)////.subscribe(x => { this.User = x; console.log(this.User); });
  }
  deleteUserById(id: string) {
    
    console.log(id);
    this.http.delete<User>(`${environment.apiUrl + 'User/'}${id}`).subscribe(x => { this.User = x; console.log(this.User); });
  }

  postUser(UserId:string,FirstName:string,LastName:string,BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Email:string,CommunityControl:number,SectorControl:string
    ) {
    this.User.UserId = UserId;
    this.User.FirstName = FirstName;
    this.User.LastName = LastName;
    this.User.Email = Email;
    this.User.CommunityId = CommunityControl;
    this.User.UserType = 0;
    this.User.BirthDate = BirthDate;
    this.User.Phone = Phone;
    this.User.Street = Street;
    this.User.HouseNumber = HouseNumber;
    this.User.Sector = SectorControl;
    console.log(this.User);
    this.http.post(environment.apiUrl + 'User/', this.User).subscribe(x => this.User);
  }
  
  putUser(UserId:string,FirstName:string,LastName:string,BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Email:string,CommunityControl:number,SectorControl:string
    ) {
      this.UserId = UserId;
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.Email = Email;
      this.CommunityId = CommunityControl;
      this.UserType = 0;
      this.BirthDate = BirthDate;
      this.Phone = Phone;
      this.Street = Street;
      this.HouseNumber = HouseNumber;
      this.Sector = SectorControl;
    console.log(this.User);
    this.http.put(environment.apiUrl + 'User/', this.User).subscribe(x => this.User);
  }
}