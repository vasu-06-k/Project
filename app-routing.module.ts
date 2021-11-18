import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { AddprojectComponent } from './addproject/addproject.component';
import { AddresumeComponent } from './addresume/addresume.component';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ResumeComponent } from './resume/resume.component';
import { ShowprojectsComponent } from './showprojects/showprojects.component';
import { WrongUserComponent } from './wrong-user/wrong-user.component';
ShowprojectsComponent

const routes: Routes = [
  {path:'LoginPage',component:LoginComponent},
  {path:'wrong-user',component:WrongUserComponent},
  {path:'home',component:HomeComponent},
  {path:'Employee-Details',component:EmployeeDetailsComponent},
  {path:'addemployee',component:AddemployeeComponent},
  {path:'addresume',component:AddresumeComponent},
  {path:'viewallresume',component:ResumeComponent},
  {path:'addproject',component:AddprojectComponent},
  {path:'viewallprojects',component:ShowprojectsComponent},
];
export default routes;
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
