import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LogInComponent } from './log-in/log-in.component';
import { AuthManagerGuard } from './shared/Services/AuthManagerGuard.guard';
import { AppComponent } from './app.component';
import { GuyComponent } from '../app/guy/guy.component'
import { SchoolComponent } from '../app/school/school.component'
import { UserComponent } from './user/user.component';
import { HomeComponent } from './home/home.component';
import { GuyAddComponent } from './guy-add/guy-add.component';
import { GuyEditComponent } from './guy-edit/guy-edit.component';
import { AddSchoolComponent } from './add-school/add-school.component';
import { AddCommunityComponent } from './add-community/add-community.component';
import { AddUserComponent } from './add-user/add-user.component';
import { ActivityComponent } from './activity/activity.component';
import { AddActivityComponent } from './add-activity/add-activity.component';
import { AddArtistComponent } from './add-artist/add-artist.component';
import { SectorComponent } from './sector/sector.component';
import { AddSectorComponent } from './add-sector/add-sector.component';
import { SignStudyHourComponent } from './sign-study-hour/sign-study-hour.component';
import { SignActivityComponent } from './sign-activity/sign-activity.component';
import { StudyHourComponent } from './study-hour/study-hour.component';
import { ReadFromExcelComponent } from './read-from-excel/read-from-excel.component';
const routes: Routes = [
  { path: '', component: HomeComponent, canActivate: [AuthManagerGuard] },
  { path: 'login', component: LogInComponent },
  { path: 'school', component: SchoolComponent },
  { path: 'guy', component: GuyComponent },
  { path: 'user', component: UserComponent },
  { path: 'guy-add', component: GuyAddComponent },
  { path: 'guy-edit/:id', component: GuyAddComponent },
  { path: 'addSchool', component: AddSchoolComponent },
  { path: 'addCommunity', component : AddCommunityComponent},
  { path:'addUser', component: AddUserComponent},
  { path:'activity', component:ActivityComponent},
  { path:'addActivity', component:AddActivityComponent},
  { path:'addArtist', component:AddArtistComponent},
  { path:'sector' ,component:SectorComponent},
  { path:'add-sector',component:AddSectorComponent},
  { path:'signHours',component:SignStudyHourComponent},
  { path:'signActivity', component:SignActivityComponent},
  { path:'studyHours' ,component:StudyHourComponent},
   { path:'read-from-excel',component:ReadFromExcelComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
