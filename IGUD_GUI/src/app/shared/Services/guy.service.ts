import { Injectable } from '@angular/core';
import { Guy } from '../Entities/Guy';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { eUserType } from '../Entities/User';

@Injectable({
  providedIn: 'root'
})

export class GuyService {
  UserId:string;
  FirstName:string;
  LastName:string;
  Email:string;
  CommunityId:number;
  UserType:eUserType;
  YeshivaId:number;
  YeshivaName:string;
  IsBig:boolean;
  IsDeleted:boolean;
  DeletionDate:Date;
  BirthDate:Date;
  Phone:string;
  Street:string;
  HouseNumber:number;
  Sector:string;
  Lesson:string;
  CommunityName:string;
  guy:Guy=new Guy(this.UserId,this.FirstName,this.LastName,this.Email,this.CommunityId,this.UserType, this.IsDeleted, this.DeletionDate, this.BirthDate,this.Phone,this.Street,this.HouseNumber,this.Sector,this.YeshivaId,this.YeshivaName,this.IsBig,this.Lesson,this.CommunityName);
    
  Guys:Guy[]=[];
     
    constructor(private http:HttpClient) { }
    //api='http://localhost:56580/api';
   
  getGuys()
  {
    this.http.get<Guy[]>(environment.apiUrl+'Guys/').subscribe(state=>{this.Guys=state;console.log(this.Guys);});
  }
    getGuyById(id:number)
    {  
      this.http.get<Guy>(`${environment.apiUrl+'Guys/'}/${id}`).subscribe(x=>{this.guy=x;console.log(this.guy);});
    }
    // deleteGuyById(id:string)
    // {  console.log(id);
    //   debugger
    //   this.http.delete<Guy>(`${environment.apiUrl+'Guys/'}/${id}`).subscribe(x=>{this.guy=x;console.log(this.guy);});
    // }     
    
    deleteGuyById(id:string)
    {  console.log(id);
      this.http.delete<Guy>(`${environment.apiUrl+'Guys'}/${id}`).subscribe(x=>{this.guy=x;console.log(this.guy);});
    }      
    
    postGuy(UserId:string,FirstName:string,LastName:string,BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Email:string,CommunityControl:number,YeshivaId:number,YeshivaName:string,IsBig:boolean,Lesson:string,SectorControl:string)
    {
      this.guy.UserId=UserId;
      this.guy.FirstName=FirstName;
      this.guy.LastName=LastName;
      this.guy.BirthDate=BirthDate;
      this.guy.Phone=Phone;
      this.guy.Email=Email;
      this.guy.CommunityId=CommunityControl;
      this.guy.UserType=1;
      this.guy.BirthDate=BirthDate;
      this.guy.YeshivaId=YeshivaId;
      this.guy.YeshivaName=YeshivaName;
      this.guy.IsBig=IsBig;
      this.guy.Sector=SectorControl;
      this.guy.Street=Street;
      this.guy.HouseNumber=HouseNumber;
      this.guy.Lesson=Lesson;
      console.log(this.guy);
      this.http.post(environment.apiUrl+'Guys/',this.guy).subscribe(x=>this.guy);
    }
    
    putGuy(UserId:string,FirstName:string,LastName:string,BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Email:string,CommunityControl:number,YeshivaId:number,YeshivaName:string,IsBig:boolean,Lesson:string,SectorControl:string)
    {
      this.guy.UserId=UserId;
      this.guy.FirstName=FirstName;
      this.guy.LastName=LastName;
      this.guy.BirthDate=BirthDate;
      this.guy.Phone=Phone;
      this.guy.Email=Email;
      this.guy.CommunityId=CommunityControl;
      this.guy.UserType=1;
      this.guy.BirthDate=BirthDate;
      this.guy.YeshivaId=YeshivaId;
      this.guy.YeshivaName=YeshivaName;
      this.guy.IsBig=IsBig;
      this.guy.Sector=SectorControl;
      this.guy.Street=Street;
      this.guy.HouseNumber=HouseNumber;
      this.guy.Lesson=Lesson;
      console.log(this.guy);
      this.http.put(environment.apiUrl+'Guys/',this.guy).subscribe(x=>this.guy);
    }
bySchool(schoolId)
{
  this.http.get<Guy[]>(`${environment.apiUrl+'Guys/BySchool'}/${schoolId}`).subscribe(x=>{this.Guys=x;console.log(this.Guys);});  
}
getBigSchool()
{
  this.http.get<Guy[]>(environment.apiUrl+'Guys/getBigSchool').subscribe(state=>{this.Guys=state;console.log(this.Guys);});
}

getSmallSchool()
{
  this.http.get<Guy[]>(environment.apiUrl+'Guys/getSmallSchool').subscribe(state=>{this.Guys=state;console.log(this.Guys);});
}

getByCommunity()
{
  this.http.get<Guy[]>(environment.apiUrl+'Guys/getByCommunity').subscribe(state=>{this.Guys=state;console.log(this.Guys);});

}
  getBySpecifiCommunity(communityId)
{
  console.log(communityId)
  this.http.get<Guy[]>(`${environment.apiUrl+'Guys/getByCommunity'}/${communityId}`).subscribe(state=>{this.Guys=state;console.log(this.Guys);});
}

getBySpecifiCSchool(SchoolId)
{
  console.log(SchoolId)
  this.http.get<Guy[]>(`${environment.apiUrl+'Guys/getBySchool'}/${SchoolId}`).subscribe(state=>{this.Guys=state;console.log(this.Guys);});
}

getByCommAndSch(SchoolId,communityId)
{
console.log(SchoolId,communityId)
this.http.get<Guy[]>(`${environment.apiUrl+'Guys/getByCommunityAndSchool'}/${communityId}/${SchoolId}`).subscribe(state=>{this.Guys=state;console.log(this.Guys);});
}
}
