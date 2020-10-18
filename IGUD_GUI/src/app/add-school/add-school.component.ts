import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {SchoolService } from '../shared/Services/school.service'
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'add-school',
  templateUrl: './add-school.component.html',
  styleUrls: ['./add-school.component.scss']
})
export class AddSchoolComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<AddSchoolComponent>,private schoolServices:SchoolService) { }

  ngOnInit() {
  }
  close()
  {
    this.dialogRef.close();
  }
}
