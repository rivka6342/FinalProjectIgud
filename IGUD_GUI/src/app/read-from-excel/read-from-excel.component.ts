// import { Component, OnInit } from '@angular/core';
// import * as XLSX from 'xlsx';

// @Component({
//   selector: 'read-from-excel',
//   templateUrl: './read-from-excel.component.html',
//   styleUrls: ['./read-from-excel.component.scss']
// })
// export class ReadFromExcelComponent implements OnInit {

//   tittle='XlsRead';
//   file:File
//   arrayBuffer:any
//   filelist:any
//   constructor() { }

//   ngOnInit() {
//   }

//   addfile(event)     
//   {    
//   this.file= event.target.files[0];     
//   let fileReader = new FileReader();    
//   fileReader.readAsArrayBuffer(this.file);     
//   fileReader.onload = (e) => {    
//       this.arrayBuffer = fileReader.result;    
//       var data = new Uint8Array(this.arrayBuffer);    
//       var arr = new Array();    
//       for(var i = 0; i != data.length; ++i) arr[i] = String.fromCharCode(data[i]);    
//       var bstr = arr.join("");    
//       var workbook = XLSX.read(bstr, {type:"binary"});    
//       var first_sheet_name = workbook.SheetNames[0];    
//       var worksheet = workbook.Sheets[first_sheet_name];    
//       console.log(XLSX.utils.sheet_to_json(worksheet,{raw:true}));    
//         var arraylist = XLSX.utils.sheet_to_json(worksheet,{raw:true});     
//             this.filelist = [];    
//             console.log(this.filelist)    
    
//   }    
// } 
   
// }

import { Component, OnInit, ViewChild } from '@angular/core';  
import { HttpClient, HttpHeaders } from '@angular/common/http';  
import { Observable } from 'rxjs';  
import { ReadFromExcelServiceService } from '../read-from-excel-service.service';  
import { User } from '../shared/Entities/User';  
  
 @Component({
   selector: 'read-from-excel',
   templateUrl: './read-from-excel.component.html',
   styleUrls: ['./read-from-excel.component.scss']
 }) 

export class ReadFromExcelComponent implements OnInit {  
  @ViewChild('fileInput',{static:true}) fileInput;  
  message: string;  
  allUsers: Observable<User[]>;  
  constructor(private http: HttpClient, private service: ReadFromExcelServiceService) { }  

  ngOnInit() {  
    this.loadAllUser();  
  }  
  loadAllUser() {  
    this.allUsers = this.service.BindUser();  
  }  
  uploadFile() {  
    let formData = new FormData();  
    formData.append('upload', this.fileInput.nativeElement.files[0])  
  
    this.service.UploadExcel(formData).subscribe(result => {  
      this.message = result.toString();  
      this.loadAllUser();  
    });   
  
  }  
}  
