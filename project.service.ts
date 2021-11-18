import { Injectable } from '@angular/core';
import { ProjectModel } from 'Models/ProjectModel';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private http:HttpClient,private r:Router) { }
  mystatus:number=0;
public api="https://localhost:44386/api/Project/PostProject";
  addproject(val:any)
  {
    this.http.post(this.api,val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus;
  }
public getapi="https://localhost:44386/api/Project/Getall";
  getProject():Observable<Array<ProjectModel>>
  {
    return this.http.get<Array<ProjectModel>>(this.getapi);
  }
}
