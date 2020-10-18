import { Component, OnInit } from '@angular/core';
import {AuthService} from '../shared/Services/auth.service';
import {SchoolService} from '../shared/Services/school.service';
@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.scss']
})
export class LogInComponent implements OnInit {

  constructor(private authService:AuthService,private schoolService:SchoolService) { }

  ngOnInit() {
  }
  
}
