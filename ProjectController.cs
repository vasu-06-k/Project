using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HRBAL1;
using HRDAL;

namespace HRProject.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProjectController : ApiController
    {
        [HttpPost]
    
        public IHttpActionResult PostProject([FromBody] Project L)
        {
            ProjectDAL dal = new ProjectDAL();
            dal.add(L);
            return Ok(new { status = 200, isSuccess = true, message = "Resume added successfully" });
        }
        [HttpGet]
        public List<Project> Getall()
        {
            ProjectDAL d = new ProjectDAL();
            List<Project> f = d.showAll();
            return f;
        }
    }
}
