import { Injectable } from '@angular/core';
import { cls_LoginModel } from 'Models/cls_LoginModel';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MyloginService {
public api='https://localhost:44386/api/LoginForm/LoginAdmin/';
public getapi='https://localhost:44386/api/';
  constructor(private http:HttpClient)
  { 

  }
  mystatus:number=0;
    postlogin(logindata:cls_LoginModel):number
    {
      let endpoints="LoginForm/LoginAdmin";
     
     this.http.post(this.getapi+endpoints,logindata).subscribe((data:any)=>{console.log(data); this.mystatus=data.status;});
      return this.mystatus;
    }
  
}
