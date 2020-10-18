
export class Community{
    
    CommunityId:number;
    CommunityName:string;
    City:string;
    Street:string;
     HouseNumber:number;
    RavName:string;
    constructor( CommunityId:number, CommunityName:string,City:string, Street:string, HouseNumber:number, RavName:string)
    {
        this.CommunityId=CommunityId;
        this.CommunityName=CommunityName;
        this.City=City;
        this.Street=Street;
        this.HouseNumber=HouseNumber;
        this.RavName=RavName;
    }

}