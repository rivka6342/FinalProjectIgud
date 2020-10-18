import { Component, OnInit } from '@angular/core';
import { SchoolService } from '../shared/Services/school.service';
import { FormControl, Validators } from '@angular/forms';
import { CommunityService } from '../shared/Services/community.service'
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from '../shared/Services/user.service';
import { SectorService } from '../shared/Services/sector.service';
import { ValidationService } from '../validation.service';
import { AddCommunityComponent } from '../add-community/add-community.component';
import {MatDialog} from '@angular/material/dialog';

@Component({
  selector: 'app-add-sector',
  templateUrl: './add-sector.component.html',
  styleUrls: ['./add-sector.component.scss']
})
export class AddSectorComponent implements OnInit {

  Sectors: string[] = ['ספרדי', 'ליטאי', 'חסידי', 'עץ'];
  Grades: string[] = ['א', 'ב', 'ג', 'קיבוץ'];
  SchoolControl = new FormControl('', Validators.required);
  SectorControl = new FormControl('', Validators.required);
  CommunityControl = new FormControl('', Validators.required);
  GradesyControl = new FormControl('', Validators.required);
  disableSelect = new FormControl(false);
  id: string;
  dialogAdd: any;

  constructor(private SectorService:SectorService, private SchoolService: SchoolService, private CommunityService: CommunityService, router: ActivatedRoute,private Router:Router
    ,private dialog:MatDialog
   ) { }
  School: any;
  Communities: any;
  ngOnInit() {
    this.SchoolService.getSchools();
    console.log(this.SchoolService.Schools);
    this.CommunityService.getCommunities();
  }
  addSch()
  {
    console.log("none");
    this.Router.navigate(['addSchool']);
  }
  addCom()
  {
    console.log("hi")
    const dialogRef=this.dialog.open(AddCommunityComponent,{
      width:'300px',
      height:'300px',
    }); 
  }
}