import { Time } from '@angular/common';

export class SignStudyHour{
    // StudyHoursId:number;
    GuyId:string;
    Date:Date;
    longStudy:number;
    StudyId:number;
    
    constructor( /*StudyHoursId:number,*/GuyId:string, Datee:Date,longStudy:number,StudyId:number)
    {
        // this.StudyHoursId=StudyHoursId;
        this.GuyId=GuyId;
        this.Date=Datee;
        this.longStudy=longStudy;
       this.StudyId=StudyId;
    }
  public SignStudyHour(){}
}