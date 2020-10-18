import {User, eUserType} from './User'

 export class Sector extends User
 {
  kind:string;
  id:number;
  constructor(UserId:string,FirstName:string,LastName:string,Email:string,CommunityId:number,UserType:eUserType,  IsDeleted:boolean, DeletionDate:Date, BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Sector:string,kind:string,id:number,communityName:string)
  {
      super(UserId,FirstName,LastName,Email,CommunityId,UserType,IsDeleted,DeletionDate,BirthDate,Phone,Street,HouseNumber,Sector,communityName);
      this.kind=kind;
       this.id=id;
  }
 }