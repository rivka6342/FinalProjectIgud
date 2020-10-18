import { Injectable } from '@angular/core';
import {Sector } from '../Entities/Sector';
import { eUserType } from '../Entities/User';
import {HttpClient,HttpHeaders} from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SectorService {

  UserId:string;
  FirstName:string;
  LastName:string;
  Email:string;
  CommunityId:number;
  UserType:eUserType;
  IsBig:boolean;
  IsDeleted:boolean;
  DeletionDate:Date;
  BirthDate:Date;
  Phone:string;
  Street:string;
  HouseNumber:number;
  Sector:string;
  kind:string;
  id:number;
  CommunityName:string;
  sector:Sector=new Sector(this.UserId,this.FirstName,this.LastName,this.Email,this.CommunityId,this.UserType, this.IsDeleted, this.DeletionDate, this.BirthDate,this.Phone,this.Street,this.HouseNumber,this.Sector,this.kind,this.id,this.CommunityName);
  Sectors:Sector[]=[];
  constructor(private http:HttpClient) { }

  getSectors()
  {
    this.http.get<Sector[]>(environment.apiUrl+'Sector/').subscribe(state=>{this.Sectors=state;console.log(this.Sectors);});
  }
    getSectorById(id:number)
    {  
      this.http.get<Sector>(`${environment.apiUrl+'Sector/'}/${id}`).subscribe(x=>{this.sector=x;console.log(this.sector);});
    }
    deleteSectorById(id:string)
    {  console.log(id);
      this.http.delete<Sector>(`${environment.apiUrl+'Sector/'}/${id}`).subscribe(x=>{this.sector=x;console.log(this.sector);});
    }      
     
      postSector( UserId:string,FirstName:string,LastName:string,BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Email:string,CommunityControl:number,SectorControl:string/*,UserType:eUserType*/,kind:string,id:number,CommunityName:string)     
    {
      console.log(UserId,FirstName,LastName,BirthDate,Phone,Street,HouseNumber,Email,CommunityControl,SectorControl);
      this.sector.UserId=UserId;
      this.sector.FirstName=FirstName;
      this.sector.LastName=LastName;
      this.sector.BirthDate=BirthDate;
      this.sector.Phone=Phone;
      this.sector.Email=Email;
      this.sector.CommunityId=CommunityControl;
      this.sector.UserType=2;
      this.sector.BirthDate=BirthDate;
      this.sector.Sector=SectorControl;
      this.sector.Street=Street;
      this.sector.HouseNumber=HouseNumber;
      this.sector.kind=kind;
      this.sector.id=id;
      this.sector.CommunityName=CommunityName;
      console.log(this.sector);
      this.http.post(environment.apiUrl+'Sector/',this.sector).subscribe(x=>this.sector);
    }
    putSector( UserId:string,FirstName:string,LastName:string,BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Email:string,CommunityControl:number,SectorControl:string/*,UserType:eUserType*/,kind:string,id:number,communityName:string)
    {
      this.sector.UserId=UserId;
      this.sector.FirstName=FirstName;
      this.sector.LastName=LastName;
      this.sector.BirthDate=BirthDate;
      this.sector.Phone=Phone;
      this.sector.Email=Email;
      this.sector.CommunityId=CommunityControl;
      this.sector.UserType=2;
      this.sector.BirthDate=BirthDate;
      this.sector.Sector=SectorControl;
      this.sector.Street=Street;
      this.sector.HouseNumber=HouseNumber;
      // this.sector.kind=kind;
      // this.sector.id=id;
      // this.sector.CommunityName=communityName;
      console.log(this.sector);
      this.http.put(environment.apiUrl+'Sector/',this.sector).subscribe(x=>this.sector);
    }
}

