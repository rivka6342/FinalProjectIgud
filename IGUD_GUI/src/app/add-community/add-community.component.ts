import { Component, OnInit } from '@angular/core';
import { CommunityService } from '../shared/Services/community.service';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'add-community',
  templateUrl: './add-community.component.html',
  styleUrls: ['./add-community.component.scss']
})
export class AddCommunityComponent implements OnInit {
checked:any;
constructor(public dialogRef: MatDialogRef<AddCommunityComponent>,private CommunityService:CommunityService) { }

  ngOnInit() {
  }
close()
{
  this.dialogRef.close();
}
}
