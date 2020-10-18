import { Injectable } from '@angular/core';
import {Artist} from '../Entities/Artist';
import {HttpClient,HttpHeaders} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ArtistService {

  ArtistId:number;
  FirstName:string;
  LastName:string;
   Kind:string;
   Phone:string;
   Email:string;

  artist:Artist=new Artist(this.ArtistId,this.FirstName,this.LastName,this.Kind,this.Phone,this.Email);
    
  artists:Artist[]=[];
     
    constructor(private http:HttpClient) { }
    api='http://localhost:56580/api';
  
    getArtists()
    {
      this.http.get<Artist[]>(this.api+'/Artist').subscribe(state=>{this.artists=state;console.log(this.artists);});
    }
   
    
    getArtistById(id:number)
    {  
      this.http.get<Artist>(`${this.api+"/Artist"}/${id}`).subscribe(x=>{this.artist=x;console.log(this.artist);});
    }
    deleteArtistById(id:number)
    {  console.log(id);
      this.http.delete<Artist>(`${this.api+"/Artist"}/${id}`).subscribe(x=>{this.artist=x;console.log(this.artist);});
    }
      
      postArtist( FirstName:string,LastName:string,Kind:string,Phone:string,Email:string)
     
    {
      this.artist.FirstName=FirstName;
      this.artist.LastName=LastName;
      this.artist.Kind=Kind;
      this.artist.Phone=Phone;
      this.artist.Email=Email;
      console.log(this.artist);
      this.http.post(this.api+'/Artist',this.artist).subscribe(x=>this.artist);
    }
    putArtist( ArtistId:number, FirstName:string,LastName:string,Kind:string,Phone:string,Email:string)
    {
      this.artist.ArtistId=ArtistId;
      this.artist.FirstName=FirstName;
      this.artist.LastName=LastName;
      this.artist.Kind=Kind;
      this.artist.Phone=Phone;
      this.Email=Email;
      console.log(this.artist);
      this.http.put(this.api+'/Guys',this.artist).subscribe(x=>this.artist);
    }
}
