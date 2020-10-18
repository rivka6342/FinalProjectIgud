import { Component, OnInit } from '@angular/core';
import { SignActivityService } from '../shared/Services/sign-activity.service';
import { FormControl, Validators } from '@angular/forms';
import { ActivityService } from '../shared/Services/activity.service';

@Component({
  selector: 'sign-activity',
  templateUrl: './sign-activity.component.html',
  styleUrls: ['./sign-activity.component.scss']
})
export class SignActivityComponent implements OnInit {

  ActivityControl=new FormControl('', Validators.required);
  constructor(private signActivityService:SignActivityService,private activityService:ActivityService) { }

  ngOnInit() { 
    console.log(this.activityService.getActivities());
    this.activityService.getActivities();
  }

}
