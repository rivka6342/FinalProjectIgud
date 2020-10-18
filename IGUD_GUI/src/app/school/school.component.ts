import { Component, OnInit, Inject } from '@angular/core';
import {SchoolService} from '../shared/Services/school.service';
import { FormControl, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { GuyService } from '../shared/Services/guy.service';
import {MatDialog} from '@angular/material';

@Component({
  selector: 'school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.scss']
})
export class SchoolComponent implements OnInit {

  SchoolControl = new FormControl('', Validators.required);

  constructor( @Inject(MAT_DIALOG_DATA) public data:any,private schoolService:SchoolService,public dialogRef: /*MatDialogRef<SchoolComponent>*/MatDialog,private guyService:GuyService) { }

  ngOnInit() {
  this.schoolService.getSchools();
  console.log(this.data)
  
  }

  choose(SchoolId)
  {
   console.log(SchoolId)
   if(this.data.is==0)
   this.guyService.getBySpecifiCSchool(SchoolId)
   if(this.data.is==1)
   this.guyService.getByCommAndSch(SchoolId,this.data.communityId)
   this.dialogRef.closeAll();
  
  }

}
