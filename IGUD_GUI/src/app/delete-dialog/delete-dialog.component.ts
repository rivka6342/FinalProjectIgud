import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { GuyService } from '../shared/Services/guy.service';
import { UserService } from '../shared/Services/user.service';
import { SectorService } from '../shared/Services/sector.service';
import { StudyHourService } from '../shared/Services/study-hour.service';


@Component({
  selector: 'delete-dialog',
  templateUrl: './delete-dialog.component.html',
  styleUrls: ['./delete-dialog.component.scss']
})
export class DeleteDialogComponent {
  
  constructor(
    public dialogRef: MatDialogRef<DeleteDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data:any,private GuyService:GuyService,private userService:UserService,private sectorService:SectorService,
    private studyHourService:StudyHourService) {}

    onClick(num:number): void {
    this.dialogRef.close();
    if(num==1)
    {
      console.log(this.data.id)
      if(this.data.userType==1)        
      this.GuyService.deleteGuyById(this.data.id);
      else if(this.data.userType==0)
       this.userService.deleteUserById(this.data.id)
       else if(this.data.userType==2)
       this.sectorService.deleteSectorById(this.data.id);
       else if(this.data.userType==3)
       {
       debugger
       this.studyHourService.deleteStudyHourById(parseInt(this.data.id));
       }
    }
  }

  // DeleteUser(num:number): void {
  //   this.dialogRef.close();
  //   if(num==1)
  //   {
  //       console.log(this.data.id)
  //     this.userService.deleteUserById(this.data.id);

  //   }
}
