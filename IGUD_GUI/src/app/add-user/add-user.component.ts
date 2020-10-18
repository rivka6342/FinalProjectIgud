import { Component, OnInit } from '@angular/core';
import { SchoolService } from '../shared/Services/school.service';
import { FormControl, Validators } from '@angular/forms';
import { CommunityService } from '../shared/Services/community.service'
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from '../shared/Services/user.service';
import { ValidationService } from '../validation.service';
import { AddCommunityComponent } from '../add-community/add-community.component';
import {MatDialog} from '@angular/material/dialog';

@Component({
  selector: 'add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit {

  Sectors: string[] = ['ספרדי', 'ליטאי', 'חסידי', 'עץ'];
  Grades: string[] = ['א', 'ב', 'ג', 'קיבוץ'];
  TzControl   = new FormControl('', Validators.required);
  FirstnameControl = new FormControl('', Validators.required);
  LastNameControl = new FormControl('', Validators.required);
  BirthDateControl = new FormControl('', Validators.required);
  PhoneControl = new FormControl('', Validators.required);
  StreetControl = new FormControl('', Validators.required);
  HouseNumberControl = new FormControl('', Validators.required);
  EmailControl = new FormControl('', Validators.required);
  // SchoolControl = new FormControl('', Validators.required);
  SectorControl = new FormControl('', Validators.required);
  CommunityControl = new FormControl('', Validators.required);
  // GradesyControl = new FormControl('', Validators.required);
  disableSelect = new FormControl(false);
  id: string;

  constructor(private userService:UserService, private SchoolService: SchoolService, private CommunityService: CommunityService, router: ActivatedRoute,private Router:Router,
              private ValidationService:ValidationService,private dialog:MatDialog) { }

  School: any;
  Communities: any;
  ngOnInit() {
    this.SchoolService.getSchools();
    console.log(this.SchoolService.Schools);
    this.CommunityService.getCommunities();
  }
  // addSch()
  // {
  //   console.log("none");
  //   this.Router.navigate(['addSchool']);
  // }
  addCom()
  {

    const dialogRef=this.dialog.open(AddCommunityComponent,{
      width:'500px',
      height:'500px',
    
    });
    this.Router.navigate(['addCommunity']);
  }
}
