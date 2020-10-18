import { Injectable } from '@angular/core';
import { Time } from '@angular/common';
import { StudyHour } from '../Entities/Studyhour';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StudyHourService {

StudyId:number;
Tittle:string;
DateStart:Date;
DateEnd:Date;
TimeStart:Time;
TimeEnd :Time;
studyHour:StudyHour=new StudyHour(this.StudyId,this.Tittle,this.DateStart,this.DateEnd,this.TimeStart,this.TimeEnd);
  
StudyHours:StudyHour[]=[];
   
  constructor(private http:HttpClient) { }
  //api='http://localhost:56580/api';

  getStudyHour()
  {
    this.http.get<StudyHour[]>(environment.apiUrl + '/StudyHour').subscribe(state=>{this.StudyHours=state;console.log(this.StudyHours);});
  }
  
  getStudyHourById(id:number)
  {  
    this.http.get<StudyHour>(`${environment.apiUrl + "/StudyHour"}/${id}`).subscribe(x=>{this.studyHour=x;console.log(this.studyHour);});
  }
  deleteStudyHourById(id:number)
  {  console.log(id);
    this.http.delete<StudyHour>(`${environment.apiUrl  +"/StudyHour"}/${id}`).subscribe(x=>{this.studyHour=x;console.log(this.studyHour);});
  }
    
    postStudyHour(tittle:string,DateStart:Date, DateEnd:Date, TimeStart:Time,TimeEnd :Time)
   
  {
    this.studyHour.DateStart=DateStart;
    this.studyHour.DateEnd=DateEnd;
    this.studyHour.TimeStart=TimeStart;
    this.studyHour.TimeEnd=TimeEnd;
    this.studyHour.tittle=tittle;
    console.log(this.studyHour);
    this.http.post(environment.apiUrl +'/StudyHour',this.studyHour).subscribe(x=>this.studyHour);
  }
  putStudyHour(tittle:string,DateStart:Date, DateEnd:Date, TimeStart:Time,TimeEnd :Time)
  {
    this.studyHour.DateStart=DateStart;
    this.studyHour.DateEnd=DateEnd;
    this.studyHour.TimeStart=TimeStart;
    this.studyHour.TimeEnd=TimeEnd;
    this.studyHour.tittle=tittle;
    console.log(this.studyHour);
    this.http.put(environment.apiUrl +'/StudyHour',this.studyHour).subscribe(x=>this.studyHour);
  }
}
