import { Injectable } from '@angular/core';  
import { HttpHeaders } from '@angular/common/http';  
import { HttpClient } from '@angular/common/http'  
import { User } from '../app/shared/Entities/User';  
import { Observable } from 'rxjs';  
  
@Injectable({  
  providedIn: 'root'  
})  
export class ReadFromExcelServiceService {  
  
  constructor(private http: HttpClient) { }  
  
  url='http://localhost:56580/Api/Excel';  
  
  UploadExcel(formData: FormData) {  
    let headers = new HttpHeaders();  
  
    headers.append('Content-Type', 'multipart/form-data');  
    headers.append('Accept', 'application/json');  
  
    const httpOptions = { headers: headers };  
  
    return this.http.post(this.url + '/UploadExcel', formData, httpOptions)  
  }  
  BindUser(): Observable<User[]> {  
    return this.http.get<User[]>(this.url + '/UserDetails');  
  }  
}
