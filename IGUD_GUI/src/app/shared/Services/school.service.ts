import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import {School} from '../Entities/School'
@Injectable({
  providedIn: 'root'
})
export class SchoolService {
  id:number;
  name:string;
  isbig:boolean;
  School:School=new School(this.id,this.name,this.isbig);
  Schools:School[]=[];
   
  constructor(private http:HttpClient) { }
  api='http://localhost:56580/api';

  getSchools()
  {
    this.http.get<School[]>(this.api+'/Schools').subscribe(state=>{this.Schools=state;console.log(this.Schools);});
  }
 
  
  getSchoolById(id:number)
  {  
    this.http.get<School>(`${this.api+"/Schools"}/${id}`).subscribe(x=>{this.School=x;console.log(this.School);});
  }
  deleteSchoolById(id:number)
  {  console.log(id);
    this.http.delete<School>(`${this.api+"/Schools"}/${id}`).subscribe(x=>{this.School=x;console.log(this.School);});
  }
  postSchool(name:string,IsBig:boolean)
  {
    this.School.Name=name;
    this.School.IsBig=IsBig;
    console.log(this.School);
    this.http.post(this.api+'/Schools',this.School).subscribe(x=>this.School);
  }
  putSchool(name:string,IsBig:boolean)
  {
    this.School.Name=name;
    this.School.IsBig=IsBig;
    console.log(this.School);
    this.http.put(this.api+'/Schools',this.School).subscribe(x=>this.School);
  }
}
