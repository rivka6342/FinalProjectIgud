import { Component, OnInit ,ViewChild,ElementRef} from '@angular/core';

@Component({
  selector: 'header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  @ViewChild('header',{static:true}) header:ElementRef;
  @ViewChild('colorPicker',{static:true}) colorPicker:ElementRef;

   constructor() { }

  logoSrc:string = "../../assets/images/Logo.png";

  ngOnInit() {
  }

  setHeaderColor()
  {
    console.log("jj")
    this.header.nativeElement.setAttribute('style',`background:${this.colorPicker.nativeElement.value}`)
  }

}
