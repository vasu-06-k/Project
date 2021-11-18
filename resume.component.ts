import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ResumeModel } from 'Models/ResumeModel';
import { ResumeService } from '../resume.service';

@Component({
  selector: 'app-resume',
  templateUrl: './resume.component.html',
  styleUrls: ['./resume.component.css']
})
export class ResumeComponent implements OnInit {
resume:Array<ResumeModel>=[]


  constructor(private p:ResumeService,private r:Router) { }

  ngOnInit(): void {
    this.p.getResume().subscribe(data => {
      this.resume = data;
    });
  }
  loginstatus:number=0;
  SendDetails(res:ResumeModel):number{
    this.loginstatus=this.p.sendResume(res);
    alert("Resume Added to EmpDet Table succesfully");
    return this.loginstatus;
  }

  Deleteresume(res:ResumeModel):number{
    this.loginstatus=this.p.deleteResume(res.ResumeId)
    alert("Resume deleted succesfully");
    return this.loginstatus;
    };
  }


