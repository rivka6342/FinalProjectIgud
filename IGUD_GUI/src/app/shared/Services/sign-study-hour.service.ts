import { Injectable } from '@angular/core';
import { SignStudyHour } from '../Entities/SignStudyHour';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class SignStudyHourService {

  // StudyHoursId:number;
  GuyId:string;
  Date:Date;
  longStudy:number;
  StudyId:number;
  signStudyHour:SignStudyHour=new SignStudyHour(/*this.StudyHoursId,*/this.GuyId,this.Date,this.longStudy,this.StudyId);

  signHours:SignStudyHour[]=[];
  constructor(private http:HttpClient) { }

  getStudies() 
  {
    this.http.get<SignStudyHour[]>(environment.apiUrl + 'SignStudyHour/').subscribe(state => { this.signHours = state; console.log(this.signHours); });
  }


  getStudyById(id: string) {
    return this.http.get<SignStudyHour>(`${environment.apiUrl + 'SignStudyHour/'}${id}`)////.subscribe(x => { this.User = x; console.log(this.User); });
  }
  deleteStudyById(id: string) {
    console.log(id);
    this.http.delete<SignStudyHour>(`${environment.apiUrl + 'SignStudyHour/'}${id}`).subscribe(x => { this.signStudyHour = x; console.log(this.signStudyHour); });
  }
  postStudy( GuyId:string, Date:Date,longStudy:number,StudyId:number)
  {
    this.signStudyHour.GuyId=GuyId;
    this.signStudyHour.Date=Date;
    this.signStudyHour.longStudy=longStudy;
    this.signStudyHour.StudyId=StudyId;
    console.log(this.signStudyHour);
    this.http.post(environment.apiUrl + 'SignStudyHour/', this.signStudyHour).subscribe(x => this.signStudyHour);
  }
  putStusy(StudyHoursId:number, GuyId:string, Date:Date,longStudy:number,StudyId:number)
  {
      // this.StudyHoursId=StudyHoursId;
      this.GuyId=GuyId;
      this.Date=Date;
      this.longStudy=longStudy;
      this.StudyId=StudyId;
    console.log(this.signStudyHour);
    this.http.put(environment.apiUrl + 'SignStudyHour/', this.signStudyHour).subscribe(x => this.signStudyHour);
  }
}
