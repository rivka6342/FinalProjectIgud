import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ValidationService {

  constructor() { }

  checkId(id:string)
  {
    console.log("hi")
    console.log(id)
     if(id.length!=9)
        return false;
     return true;
  }
}
