import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AuthService } from './auth.service';
import { eUserType } from '../Entities/User';

@Injectable({ providedIn: 'root' })
export class AuthManagerGuard implements CanActivate {
    constructor(private router: Router, private authService: AuthService) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        //     let t=this.authService.currentuser();
        //     console.log(t);
        //    let y=this.authService.typecurrentuser();
        //    console.log(y)
        if (this.authService.typecurrentuser() == eUserType.Manager)
         {
            return true;
        }
        else {
            this.router.navigate(['/login']);
            return false;
        }
    }
}