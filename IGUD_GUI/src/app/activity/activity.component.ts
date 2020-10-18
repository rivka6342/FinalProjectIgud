import { Component, OnInit } from '@angular/core';
import { ActivityService } from '../shared/Services/activity.service';
import { Router } from '@angular/router';

@Component({
  selector: 'activity',
  templateUrl: './activity.component.html',
  styleUrls: ['./activity.component.scss']
})
export class ActivityComponent implements OnInit {

  constructor(private activityService:ActivityService,private router:Router) { }

  ngOnInit() {
    this.activityService.getActivities();
   }
add()
{
this.router.navigate(['addActivity']);
}
}
