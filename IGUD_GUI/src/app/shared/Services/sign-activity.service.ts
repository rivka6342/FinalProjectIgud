import { Injectable } from '@angular/core';
import { SignActivity } from '../Entities/SignActivity';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SignActivityService {
  
  UserId:string;
  Activity:number;
  signActivityId:number;
  SignActivity:SignActivity=new SignActivity(this.UserId,this.Activity/*,this.signActivityId*/)
  signActivities:SignActivity[]=[];

  constructor(private http:HttpClient) { }

  getActivities() 
  {
    this.http.get<SignActivity[]>(environment.apiUrl + 'SignActivity/').subscribe(state => { this.signActivities = state; console.log(this.signActivities); });
  }


  getActivityById(id: string) {
    return this.http.get<SignActivity>(`${environment.apiUrl + 'SignActivity/'}${id}`)////.subscribe(x => { this.User = x; console.log(this.User); });
  }
  deleteStudyById(id: string) {
    console.log(id);
    this.http.delete<SignActivity>(`${environment.apiUrl + 'SignActivity/'}${id}`).subscribe(x => { this.SignActivity = x; console.log(this.SignActivity); });
  }
  postActivity( userId:string,activityId:number)
  {
    console.log(userId,activityId)
    this.SignActivity.GuyId=userId;
    this.SignActivity.ActivyId=activityId;
    console.log(this.SignActivity);
    this.http.post(environment.apiUrl + 'SignActivity/', this.SignActivity).subscribe(x => this.SignActivity);
  }

  putActivity(UserId:string,Activity:number,signActivityId:number)
  {
    this.SignActivity.GuyId=UserId;
    this.SignActivity.ActivyId=Activity;
    this.signActivityId=signActivityId;
    console.log(this.SignActivity);
    this.http.put(environment.apiUrl + 'SignActivity/', this.SignActivity).subscribe(x => this.SignActivity);
  }
}
