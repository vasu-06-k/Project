import { Component, OnInit } from '@angular/core';
import { cls_LoginModel } from 'Models/cls_LoginModel';
import { MyloginService } from '../mylogin.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
username='';
password:string='';
  constructor(private m1:MyloginService) { }

  ngOnInit(): void {
  }

  loginStatus:number=0;
  validate(login:cls_LoginModel):number{
 
    this.loginStatus=this.m1.postlogin(login);
    console.log(login.username+this.loginStatus)
    return this.loginStatus;
  }

}
