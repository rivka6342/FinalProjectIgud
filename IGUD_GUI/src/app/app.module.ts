import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule,ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogInComponent } from './log-in/log-in.component';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {HttpClientModule} from '@angular/common/http';
import { SchoolComponent } from './school/school.component';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { UserComponent } from './user/user.component';
import { GuyComponent } from './guy/guy.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import {MatTableModule} from '@angular/material/table';
import { GuyAddComponent } from './guy-add/guy-add.component';
import {MatMenuModule} from '@angular/material/menu';
import {MatSelectModule} from '@angular/material/select';
import { AddSchoolComponent } from './add-school/add-school.component';
import { GuyEditComponent } from './guy-edit/guy-edit.component';
import { AddCommunityComponent } from './add-community/add-community.component';
import { AddUserComponent } from './add-user/add-user.component';
import { ActivityComponent } from './activity/activity.component';
import { AddActivityComponent } from './add-activity/add-activity.component';
import { AddArtistComponent } from './add-artist/add-artist.component';
import { SectorComponent } from './sector/sector.component';
import { AddSectorComponent } from './add-sector/add-sector.component';
import { SignActivityComponent } from './sign-activity/sign-activity.component';
import { SignStudyHourComponent } from './sign-study-hour/sign-study-hour.component';
import { DeleteDialogComponent } from './delete-dialog/delete-dialog.component';
import {MatDialogModule} from '@angular/material/dialog';
import { CommunityComponent } from './community/community.component';
import { StudyHourComponent } from './study-hour/study-hour.component';
import { AddStudyHourComponent } from './add-study-hour/add-study-hour.component';
import { ReadFromExcelComponent } from './read-from-excel/read-from-excel.component';


@NgModule({
  declarations: [
    AppComponent,
    LogInComponent,
    SchoolComponent,
    UserComponent,
    GuyComponent,
    HomeComponent,
    HeaderComponent,
    GuyAddComponent,
    AddSchoolComponent,
    GuyEditComponent,
    AddCommunityComponent,
    AddUserComponent,
    ActivityComponent,
    AddActivityComponent,
    AddArtistComponent,
    SectorComponent,
    AddSectorComponent,
    SignActivityComponent,
    SignStudyHourComponent,
    DeleteDialogComponent,
    CommunityComponent,
    StudyHourComponent,
    AddStudyHourComponent,
    ReadFromExcelComponent
  
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatCheckboxModule,
    MatTableModule,
    MatMenuModule,
    MatSelectModule,
    ReactiveFormsModule,
    MatDialogModule

  ],
  entryComponents:[GuyComponent,DeleteDialogComponent,CommunityComponent,AddStudyHourComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
