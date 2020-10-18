export class Activity{
    ActiveId:number;
    Date:Date;
    Describe:string;
    NumSubscibers:number;
    ArtistId:number;
    Prepay:boolean;
    Tittle:string;
    constructor(ActiveId:number,Date:Date,Describe:string,NumSubscibers:number,ArtistId:number,Prepay:boolean,Tittle:string)
    {
        this.ActiveId=ArtistId;
        this.Date=Date;
        this.Describe=Describe;
        this.NumSubscibers=NumSubscibers;
        this.ArtistId=ArtistId;
        this.Prepay=Prepay;
        this.Tittle=Tittle;
    }
    
    public Activity()
    {
        
    }
 
}