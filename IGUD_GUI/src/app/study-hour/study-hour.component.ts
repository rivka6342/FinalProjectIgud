import { Component, OnInit } from '@angular/core';
import { StudyHourService } from '../shared/Services/study-hour.service';
import { DeleteDialogComponent } from '../delete-dialog/delete-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { AddStudyHourComponent } from '../add-study-hour/add-study-hour.component';

@Component({
  selector: 'study-hour',
  templateUrl: './study-hour.component.html',
  styleUrls: ['./study-hour.component.scss']
})
export class StudyHourComponent implements OnInit {

  constructor(private studyHourService:StudyHourService,private dialog:MatDialog) { }

  ngOnInit() {
    this.studyHourService.getStudyHour();
  }

  openDialog(Id:number): void {
    const dialogRef = this.dialog.open(DeleteDialogComponent, {
      width: '300px'
      ,
      data: {id:Id,
        userType:3}
    });
  }
  
  add()
{
  const dialogRef=this.dialog.open(AddStudyHourComponent,{
    width:'500px',
    height:'500px',
  
  });
}

}
