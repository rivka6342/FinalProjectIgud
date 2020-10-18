import { Time } from '@angular/common';

export class StudyHour{
StudyId:number;
tittle:string;
DateStart:Date;
DateEnd:Date;
TimeStart:Time;
TimeEnd :Time;

constructor(StudyId:number,tittle:string,DateStart:Date,DateEnd:Date,TimeStart:Time,TimeEnd :Time)
{
    this.StudyId=StudyId;
    this.DateStart=DateStart;
    this.DateEnd=DateEnd;
    this.TimeStart=TimeStart;
    this.TimeEnd=TimeEnd;
    this.tittle=tittle;
}
public StudyHour(){}
 }