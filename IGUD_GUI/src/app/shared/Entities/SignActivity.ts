
export class SignActivity
{

     GuyId:string;
     ActivyId:number;
signActivityId:number;

constructor(UserId:string,Activity:number/*,signActivityId:number*/)
{
    this.GuyId=UserId;
    this.ActivyId=Activity;
    //this.signActivityId=signActivityId
} 
}