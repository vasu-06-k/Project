import { Component, OnInit } from '@angular/core';
import { ResumeModel } from 'Models/ResumeModel';
import { ResumeService } from '../resume.service';

@Component({
  selector: 'app-addresume',
  templateUrl: './addresume.component.html',
  styleUrls: ['./addresume.component.css']
})
export class AddresumeComponent implements OnInit {
addr:ResumeModel={
  ResumeId:0,
  FullName:'',
  DOB:new Date(),
  Age:0,
  Email:'', 
  PhoneNo:0,
  Gender :'',
  Address: '',
  Nationality:'', 
  Experience:'',
  Interest :'',
  Specialization:'',
  TenthPercent :0,
  TwelfthPercent :0,
  College:'',
  GraduationCourse:'',
  Branch:'',
  YearOfGraduation:0,
  TotalCGPA:0,
  Filepath:"anonymous.txt"
}
  constructor(private p:ResumeService) { }

  ngOnInit(): void {
  }
  loginstatus:number=0;
  addresume(res:ResumeModel):number
  {
    this.loginstatus=this.p.addresume(res);
    alert("Resume Added succesfully");
    return this.loginstatus;
    
  }
  PhotoFileName:string='';
uploadfile(event:any){
  var file=event.target.files[0];
  const formData:FormData=new FormData();
  formData.append('uploadedFile',file,file.name);

  this.p.UploadPhoto(formData).subscribe((data:any)=>{
    this.PhotoFileName=data.toString();
    this.PhotoFileName=this.p.PhotoUrl+this.PhotoFileName;
  })
}
}
