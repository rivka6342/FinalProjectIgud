import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { ArtistService } from '../shared/Services/artist.service';

@Component({
  selector: 'add-artist',
  templateUrl: './add-artist.component.html',
  styleUrls: ['./add-artist.component.scss']
})
export class AddArtistComponent implements OnInit {
kinds:string[]=["זיץ","הרצאה"]
KindControl = new FormControl('', Validators.required);
  constructor(private artistService:ArtistService) { }

  ngOnInit() {
  }

}
