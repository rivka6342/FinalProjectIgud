import { Component, OnInit } from '@angular/core';
import { StudyHourService } from '../shared/Services/study-hour.service';
import { FormControl, Validators } from '@angular/forms';
import { SignStudyHourService } from '../shared/Services/sign-study-hour.service';

@Component({
  selector: 'sign-study-hour',
  templateUrl: './sign-study-hour.component.html',
  styleUrls: ['./sign-study-hour.component.scss']
})
export class SignStudyHourComponent implements OnInit {

  constructor(private studyService:StudyHourService,private signStudyService:SignStudyHourService) { }
  StudyControl=new FormControl('', Validators.required);
  ngOnInit() {
    this.studyService.getStudyHour();
  }
}
