import { Injectable } from '@angular/core';
import { Activity } from '../Entities/Activity';
import {HttpClient,HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ActivityService {

  ActiveId:number;
    Date:Date;
    Describe:string;
    NumSubscibers:number;
    ArtistId:number;
    Prepay:boolean;
    Tittle:string;
    Activity:Activity=new Activity(this. ActiveId,this.Date,this.Describe, this.NumSubscibers, this. ArtistId ,this.Prepay,this.Tittle);
    Activities:Activity[]=[];
  constructor(private http:HttpClient) { }
  api='http://localhost:56580/api';

  getActivities()
  {
    this.http.get<Activity[]>(this.api+'/Activity').subscribe(state=>{this.Activities=state;console.log(this.Activities);});
  }
 
  
  getActivityById(id:number)
  {  
    this.http.get<Activity>(`${this.api+"/Activity"}/${id}`).subscribe(x=>{this.Activity=x;console.log(this.Activity);});
  }
  deleteActivityById(id:number)
  {  console.log(id);
    this.http.delete<Activity>(`${this.api+"/Activity"}/${id}`).subscribe(x=>{this.Activity=x;console.log(this.Activity);});
  }
  postActivity(Tittle:string, Datee:Date,Describe:string,NumSubscibers:number,ArtistId:number,Prepay:boolean)
  {
    this.Activity.Tittle=Tittle;
   this.Activity.Date=Datee;
    this.Activity.Describe=Describe;
    this.Activity.NumSubscibers=NumSubscibers;
    this.Activity.ArtistId=ArtistId;
    this.Activity.Prepay=Prepay;
    console.log(this.Activity);
    this.http.post(this.api+'/Activity',this.Activity).subscribe(x=>this.Activity);
  }
  putActivity( ActiveId:number, Datee:Date,Describe:string,NumSubscibers:number,ArtistId:number,Prepay:boolean,Tittle:string)
  {
    this.Activity.ActiveId=ActiveId;
    this.Activity.Date=Datee;
     this.Activity.Describe=Describe;
     this.Activity.NumSubscibers=NumSubscibers;
     this.Activity.ArtistId=ArtistId;
     this.Activity.Prepay=Prepay;
     this.Activity.Tittle=Tittle;
    console.log(this.Activity);
    this.http.put(this.api+'/Activity',this.Activity).subscribe(x=>this.Activity);
  }
}
