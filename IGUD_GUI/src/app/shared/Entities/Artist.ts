export class Artist{
    ArtistId:number;
    FirstName:string;
    LastName:string;
     Kind:string;
     Phone:string;
     Email:string;

 constructor( ArtistId:number,FirstName:string,LastName:string,Kind:string,Phone:string,Email:string)
 {
    this.ArtistId=ArtistId;
    this.FirstName=FirstName;
    this.LastName=LastName;
    this.Kind=Kind;
    this.Phone=Phone;
    this.Email=Email;
 }
 public Artist()
 {
     
 }
}