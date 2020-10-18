import { Component, OnInit, Inject } from '@angular/core';
import { StudyHourService } from '../shared/Services/study-hour.service';
import { MatDialogRef, MatDialog, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-add-study-hour',
  templateUrl: './add-study-hour.component.html',
  styleUrls: ['./add-study-hour.component.scss']
})
export class AddStudyHourComponent implements OnInit {

  constructor(private studyHourService:StudyHourService,private dialog:MatDialogRef<AddStudyHourComponent>,
    @Inject(MAT_DIALOG_DATA) public data:any) { }

  ngOnInit() {
  }
  
  onClick(): void 
  {
    this.dialog.close();
  }

}
