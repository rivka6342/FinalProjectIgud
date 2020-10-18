import { Component, OnInit,Inject, ViewChild, ElementRef } from '@angular/core';
import { GuyService } from '../shared/Services/guy.service';
import { SchoolService } from '../shared/Services/school.service';
import { FormControl, Validators } from '@angular/forms';
import { CommunityService } from '../shared/Services/community.service'
import { ActivatedRoute, Router } from '@angular/router';
import { Guy } from '../shared/Entities/Guy';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import {AddCommunityComponent } from '../add-community/add-community.component'
import {MatDialog} from '@angular/material/dialog';
import {AddSchoolComponent } from '../add-school/add-school.component'

@Component({
  selector: 'app-guy-add',
  templateUrl: './guy-add.component.html',
  styleUrls: ['./guy-add.component.scss']
})
export class GuyAddComponent implements OnInit {

  Sectors: string[] = ['ספרדי', 'ליטאי', 'חסידי', 'עץ'];
  Grades: string[] = ['א', 'ב', 'ג', 'קיבוץ'];
  SchoolControl = new FormControl('', [Validators.required,Validators.pattern("/^abc/")]);
  SectorControl = new FormControl('', Validators.required);
  CommunityControl = new FormControl('', Validators.required);
  GradesyControl = new FormControl('', Validators.required);
  disableSelect = false;
  id: string;
  guy:any;
  @ViewChild('tz',{static:true})tz:ElementRef;
  dialog: any;
  
  constructor(public dialogRef: MatDialogRef<GuyAddComponent>, 
    @Inject(MAT_DIALOG_DATA) public data:any ,private guyService: GuyService, private SchoolService: SchoolService, private CommunityService: CommunityService, router: ActivatedRoute, private Router: Router,public dialogAdd:MatDialog) {
    // this.id = router.snapshot.paramMap.get("id");
    // console.log(this.id)
  }
 
  School: any;
  Communities: any;
  ngOnInit() {
    console.log(this.data.id);
    this.SchoolService.getSchools();
    console.log(this.SchoolService.Schools);
    this.CommunityService.getCommunities();
    //  console.log(this.id)
    //edit
    if (this.data.id)
      this.extractDetails();
  }
  extractDetails() {
 console.log("details")
   this.guy=this.guyService.getGuyById(/*parseInt(*/this.data.id)/*)*/;
   console.log(this.guy.Lesson)
   console.log(this.guy.Sector)
   console.log(this.guy.Street)
   console.log(this.guy.Phone)

}
  IsBig(schoolControl: any) {

    console.log(schoolControl);
    console.log(this.disableSelect)
    console.log("hello blur");
    this.disableSelect = schoolControl.IsBig;
    console.log(this.disableSelect)
  }
  addSch() {
    console.log("none");
    const dialogRef=this.dialogAdd.open(AddSchoolComponent,{
      width:'300px',
      height:'300px'
    }); 
    // this.Router.navigate(['addSchool']);
  }
  addCom() {
    console.log("hi")
    const dialogRef=this.dialogAdd.open(AddCommunityComponent,{
      width:'300px',
      height:'300px',
    }); 
    // this.Router.navigate(['addCommunity']);
  }
  onClick(): void 
  {
    this.dialogRef.close();
  }
}
