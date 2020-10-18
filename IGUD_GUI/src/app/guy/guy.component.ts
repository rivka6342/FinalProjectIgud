import { Component, OnInit } from '@angular/core';
import {GuyService} from '../shared/Services/guy.service';
import{Router}from'@angular/router'
import {MatDialog} from '@angular/material/dialog';
import { DeleteDialogComponent } from '../delete-dialog/delete-dialog.component';
import { tick } from '@angular/core/testing';
import { GuyAddComponent } from '../guy-add/guy-add.component';
import { CommunityComponent } from '../community/community.component'
import {SchoolComponent} from '../school/school.component'
import { SignStudyHourService } from '../shared/Services/sign-study-hour.service';
@Component({
  selector: 'app-guy',
  templateUrl: './guy.component.html',
  styleUrls: ['./guy.component.scss']
})
export class GuyComponent implements OnInit {

  animal: string;
  name: string;
  Guy:any;
  constructor(private guyService:GuyService,private router:Router,private dialog: MatDialog,private StudyHoursService:SignStudyHourService) { }
  
  ngOnInit() {
    this.guyService.getGuys();
  }
//   add()
// { 
// this.router.navigate(['guy-add']);
// }
//  put(UserId:string)
//  {
//    console.log(UserId)
//    this.router.navigate(['guy-edit',UserId]);
//  }

 //put(UserId,FirstName:string,LastName:string,Email:string,CommunityName:string,YeshivaName:string,BirthDate:Date,IsBig:boolean,):void
 put(UserId):void
{
   console.log(UserId)
  //  console.log(this.guyService.guy)
  //  console.log( this.guyService.getGuyById(UserId))
  //  this.Guy=this.guyService.getGuyById(UserId)
  //  console.log(this.Guy.CommunityName)
  //  console.log(this.Guy)
  //  console.log(this.Guy.YeshivaName)

  const dialogRef=this.dialog.open(GuyAddComponent,{
    width:'500px',
    height:'500px',
    //  data:{id:UserId,fname:FirstName,lname:LastName,email:Email,communityNmae:CommunityName,yeshivaName:YeshivaName,birthDate:BirthDate,isBig:IsBig}
         data:{id:UserId}
  });
}

 add():void
 {   
   const dialogRef=this.dialog.open(GuyAddComponent,{
     width:'500px',
     height:'500px',
   
   });
}
openDialog(Id:number): void {
  const dialogRef = this.dialog.open(DeleteDialogComponent, {
    width: '300px'
    ,
    data: {id:Id,
     userType:1}
  });

  // dialogRef.afterClosed().subscribe(result => {
  //   console.log('The dialog was closed');
  //   this.animal = result;
  // });
}

BySchool()
{
  console.log("hiiii!!")
  const dialogRef=this.dialog.open(SchoolComponent,{
    width:'300px',
    height:'300px',
    data:{is:0}

  });  

}

openCommunities()
{
  console.log("com")
  const dialogRef=this.dialog.open(CommunityComponent,{
    width:'300px',
    height:'300px',
  
  });  
}

ShowStudyHours()
{
this.StudyHoursService.getStudies();

}
}
