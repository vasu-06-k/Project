import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import routes,{ AppRoutingModule } from './app-routing.module';
import { MyloginService } from './mylogin.service';

import { RouterModule } from '@angular/router';

import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { WrongUserComponent } from './wrong-user/wrong-user.component';
import { HomeComponent } from './home/home.component';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { ResumeComponent } from './resume/resume.component';
import { ResumeService } from './resume.service';
import { AddresumeComponent } from './addresume/addresume.component';
import { AddprojectComponent } from './addproject/addproject.component';
import { ShowprojectsComponent } from './showprojects/showprojects.component';
import { ProjectService } from './project.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    WrongUserComponent,
    HomeComponent,
    EmployeeDetailsComponent,
    AddemployeeComponent,
    ResumeComponent,
    AddresumeComponent,
    AddprojectComponent,
    ShowprojectsComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    FormsModule
   
  ],
  providers: [ProjectService],
  bootstrap: [AppComponent]
})
export class AppModule { }
