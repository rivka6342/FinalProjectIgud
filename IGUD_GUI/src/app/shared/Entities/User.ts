export enum eUserType {
  Coordinator, Guy, Sector, Manager
}

export class User {
  UserId: string;
  FirstName: string;
  LastName: string;
  Email: string;
  CommunityId: number;
  UserType: eUserType;
  IsDeleted: boolean;
  DeletionDate: Date;
  BirthDate: Date;
  Phone: string;
  Street: string;
  HouseNumber: number;
  Sector: string;
  CommunityName:string;
  
  constructor(UserId: string, FirstName: string, LastName: string, Email: string, CommunityId: number, UserType: eUserType, IsDeleted: boolean, DeletionDate: Date, BirthDate: Date, Phone: string, Street: string, HouseNumber: number, Sector: string,CommunityName:string
    ) {
    this.UserId = UserId;
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.Email = Email;
    this.CommunityId = CommunityId;
    this.UserType = UserType;
    this.IsDeleted = IsDeleted;
    this.DeletionDate = DeletionDate;
    this.BirthDate = BirthDate;
    this.Phone = Phone;
    this.Street = Street;
    this.HouseNumber = HouseNumber;
    this.Sector = Sector;
    this.CommunityName=CommunityName;
  }
  public User() { }

}