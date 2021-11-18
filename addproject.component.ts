import { Component, OnInit } from '@angular/core';
import { ProjectModel } from 'Models/ProjectModel';
import { ProjectService } from '../project.service';

@Component({
  selector: 'app-addproject',
  templateUrl: './addproject.component.html',
  styleUrls: ['./addproject.component.css']
})
export class AddprojectComponent implements OnInit {

  constructor(private p:ProjectService) { }
addp:ProjectModel={
  ProjectId:0,
  ProjectName:'',
  ClientName:'',
  NoOfDays:0
}
  ngOnInit(): void {

  }
  loginstatus:number=0;
  addpro(pro:ProjectModel):number
  {
    this.loginstatus=this.p.addproject(pro);
    alert("Project Added succesfully");
    return this.loginstatus;
    
  }

}
