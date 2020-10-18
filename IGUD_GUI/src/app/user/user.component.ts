import { Component, OnInit } from '@angular/core';
import { UserService } from '../shared/Services/user.service';
import { Router } from '@angular/router';
import { CommunityService } from '../shared/Services/community.service';
import { DeleteDialogComponent } from '../delete-dialog/delete-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { AddUserComponent } from '../add-user/add-user.component';

@Component({
  selector: 'user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {

  constructor(private UserService:UserService,private router:Router,private communityService:CommunityService,public dialog: MatDialog) { }

  ngOnInit() {
    this.UserService.getUsers();
  }

add()
{

  const dialogRef=this.dialog.open(AddUserComponent,{
    width:'500px',
    height:'500px',
  
  });
}
geyCommunity(item)
{
  console.log("get community");
return this.communityService.getCommunityById(item);

}
openDialog(Id:number): void {
  const dialogRef = this.dialog.open(DeleteDialogComponent, {
    width: '300px'
    ,
    data: {id:Id,
      userType:0}
  });

}
}
