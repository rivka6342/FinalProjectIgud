import { Component, OnInit, Inject } from '@angular/core';
import { CommunityService } from '../shared/Services/community.service';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { FormControl, Validators } from '@angular/forms';
import { GuyService } from '../shared/Services/guy.service';
import { SchoolComponent } from '../school/school.component';
import {MatDialog} from '@angular/material/dialog';
@Component({
  selector: 'app-community',
  templateUrl: './community.component.html',
  styleUrls: ['./community.component.scss']
})
export class CommunityComponent implements OnInit {

  CommunityControl = new FormControl('', Validators.required);

  constructor(public CommunityService:CommunityService,public dialogRef: MatDialogRef<CommunityComponent>,private guyService:GuyService,private dialog:MatDialog){ } 
      
  ngOnInit() {
    this.CommunityService.getCommunities();
  }

  choose(communityId)
  {
   console.log(communityId)
   this.guyService.getBySpecifiCommunity(communityId)
   this.dialogRef.close();
   
  }

  school(communityId)
  {
    console.log("hiiii!!")
  const dialogRef=this.dialog.open(SchoolComponent,{
    width:'300px',
    height:'300px',  
    data:{is:1,communityId:communityId}
  });  
  }

}
