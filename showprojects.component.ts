import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProjectModel } from 'Models/ProjectModel';
import { ProjectService } from '../project.service';

@Component({
  selector: 'app-showprojects',
  templateUrl: './showprojects.component.html',
  styleUrls: ['./showprojects.component.css']
})
export class ShowprojectsComponent implements OnInit {

  constructor(private p:ProjectService,private r:Router) { }
prolist:Array<ProjectModel>=[];
  ngOnInit(): void {
    this.p.getProject().subscribe(data => {
      this.prolist = data;
    });

  }
addproj(){
  this.r.navigate(['/addproject']);
}
}
