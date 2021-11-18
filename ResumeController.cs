using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using HRBAL1;
using HRDAL;

namespace HRProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
   [RoutePrefix("api/VTRouting")]
    public class ResumeController : ApiController
    {
        
        [HttpPost]
        [Route("addresume")]
        public IHttpActionResult PostResume([FromBody] ResumeBAL L)
        {
            ResumeDAL dal = new ResumeDAL();
            dal.add(L);
            return Ok(new { status = 200, isSuccess = true, message = "Resume added successfully" });
        }
        [HttpGet]
        public List<ResumeBAL> Getall()
        {
            ResumeDAL d = new ResumeDAL();
            List<ResumeBAL> f = d.showAll();
            return f;
        }

        [HttpPost]
        [Route("SaveFile")]
        public string SaveFile()
        {
                ResumeDAL dal = new ResumeDAL();
                var httpRequest = HttpContext.Current.Request;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = HttpContext.Current.Server.MapPath("~/ResumeFiles/" + filename);
                postedFile.SaveAs(physicalPath);
                dal.sendfilepath(physicalPath);
                return filename;
         
           
        }

        [HttpPost]
        [Route("ResumetoEmpDet")]
        public IHttpActionResult PosttoEmpDet([FromBody] ResumeBAL L)
        {
            
            ResumeDAL dal = new ResumeDAL();
            dal.send(L);
            return Ok(new { status = 200, isSuccess = true, message = "Resume added to EmployeeDetails Table successfully" });
        }

        [HttpDelete]
  
        public IHttpActionResult Delete(int id)
        {
            ResumeDAL dal = new ResumeDAL();
            dal.deleteresume(id);
            return Ok(new { status = 200, isSuccess = true, message = "Resume deleted successfully" });
        }
    }
}
