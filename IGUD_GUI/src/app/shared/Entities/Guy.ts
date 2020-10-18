import {User, eUserType} from './User'
import { School } from './School';
export class Guy extends User{
    YeshivaId:number;
    YeshivaName:string;
    IsBig:boolean;
    Lesson:string;
constructor(UserId:string,FirstName:string,LastName:string,Email:string,CommunityId:number,UserType:eUserType,  IsDeleted:boolean, DeletionDate:Date, BirthDate:Date,Phone:string,Street:string,HouseNumber:number,Sector:string,YeshivaId:number, YeshivaName:string, IsBig:boolean,Lesson:string,CommunityName:string
        )       
    {
        super(UserId,FirstName,LastName,Email,CommunityId,UserType,IsDeleted,DeletionDate,BirthDate,Phone,Street,HouseNumber,Sector,CommunityName);
        this.YeshivaId=YeshivaId;
        this.YeshivaName=YeshivaName;
        this.IsBig=IsBig;
        this.Lesson=Lesson;

    }
    public Guy() { } 
}