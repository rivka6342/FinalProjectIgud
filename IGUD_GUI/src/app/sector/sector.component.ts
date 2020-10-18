import { Component, OnInit } from '@angular/core';
import { SectorService } from '../shared/Services/sector.service';
import { Router } from '@angular/router';
import { DeleteDialogComponent } from '../delete-dialog/delete-dialog.component';
import {MatDialog} from '@angular/material/dialog';
import { AddSectorComponent } from '../add-sector/add-sector.component';

@Component({
  selector: 'app-sector',
  templateUrl: './sector.component.html',
  styleUrls: ['./sector.component.scss']
})
export class SectorComponent implements OnInit {

  constructor(private sectorService:SectorService,private router:Router,public dialog: MatDialog) { }

  ngOnInit() {    
    this.sectorService.getSectors();
  }

add()
{
  const dialogRef=this.dialog.open(AddSectorComponent,{
    width:'500px',
    height:'500px',
  
  });
}

openDialog(Id:number): void {
  const dialogRef = this.dialog.open(DeleteDialogComponent, {
    width: '300px'
    ,
    data: {id:Id,
     userType:2}
  });
}

}
