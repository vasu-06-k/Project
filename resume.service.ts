import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ResumeModel } from 'Models/ResumeModel';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ResumeService {
public getapi="https://localhost:44386/api/Resume/Getall";
  constructor(private http:HttpClient,private r:Router) { }
  getResume():Observable<Array<ResumeModel>>
  {
    return this.http.get<Array<ResumeModel>>(this.getapi);
  }
mystatus:number=0;
public api="https://localhost:44386/api/VTRouting/addresume";
  addresume(val:any)
  {
    this.http.post(this.api,val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus;
  }

public Api="https://localhost:44386/api/VTRouting/ResumetoEmpDet";
  sendResume(val:any)
  {
  this.http.post(this.Api,val).subscribe((data:any)=>{this.mystatus=data.status});
  return this.mystatus;
  }

  public APIUrl="https://localhost:44386/api/VTRouting/SaveFile";
public PhotoUrl = "http://localhost:44386/ResumeFiles/";
  UploadPhoto(val:any){
    return this.http.post(this.APIUrl,val);
  }
  
  deleteResume(val:any)
  {
     let API:string="https://localhost:44386/api/VTRouting/"+val;
    this.http.delete(API).subscribe((data:any)=>{this.mystatus=data.status});
    return this.mystatus;
  }
}
