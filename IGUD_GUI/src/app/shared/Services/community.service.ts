import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import {Community} from '../Entities/community'
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class CommunityService {

   CommunityId:number;
    CommunityName:string;
    City:string;
    Street:string;
     HouseNumber:number;
    RavName:string;

    Community:Community=new Community(this.CommunityId,this.CommunityName,this.City,this.Street,this.HouseNumber,this.RavName);
    Communities:Community[]=[];
  constructor(private http:HttpClient) { }
 // api='http://localhost:56580/api';

  getCommunities()
  {
    this.http.get<Community[]>(environment.apiUrl+'/Community').subscribe(state=>{this.Communities=state;console.log(this.Communities);});
  }
 
  
  getCommunityById(id:number)
  {  
    this.http.get<Community>(`${environment.apiUrl+"/Community"}/${id}`).subscribe(x=>{this.Community=x;console.log(this.Community);});
  }
  deleteCommunityById(id:number)
  {  console.log(id);
    this.http.delete<Community>(`${environment.apiUrl+"/Community"}/${id}`).subscribe(x=>{this.Community=x;console.log(this.Community);});
  }
  postCommunity( CommunityName:string,RavName:string,Street:string,HouseNumber:number,City:string)
  {
    this.Community.CommunityName=CommunityName;
    this.Community.City=City;
    this.Community.Street=Street;
     this.Community.HouseNumber=HouseNumber;
    this.Community.RavName=RavName;
    console.log(this.Community);
    this.http.post(environment.apiUrl+'/Community',this.Community).subscribe(x=>this.Community);
  }
  putCommunity(CommunityName:string,RavName:string,Street:string,HouseNumber:number,City:string)
  {
    this.Community.CommunityName=CommunityName;
    this.Community.City=City;
    this.Community.Street=Street;
     this.Community.HouseNumber=HouseNumber;
    this.Community.RavName=RavName;
    console.log(this.Community);
    this.http.put(environment.apiUrl+'/Community',this.Community).subscribe(x=>this.Community);
  }
}
