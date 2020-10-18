import { Component, OnInit } from '@angular/core';
import { ActivityService } from '../shared/Services/activity.service';
import { ArtistService } from '../shared/Services/artist.service';
import { FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'add-activity',
  templateUrl: './add-activity.component.html',
  styleUrls: ['./add-activity.component.scss']
})
export class AddActivityComponent implements OnInit {

  ArtistControl = new FormControl('', Validators.required);
  constructor(private activityService:ActivityService,private artistService:ArtistService,private router:Router) { }

  ngOnInit() {
    this.artistService.getArtists();

  }
addArtist()
{
this.router.navigate(['addArtist']);
}
}
