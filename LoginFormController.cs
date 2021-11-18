using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using HRBAL1;
using HRDAL;
using System.Web.Http.Cors;
using System.Data;

namespace HRProject.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix("api/VTRouting")]
    public class LoginFormController : ApiController
    {
        [HttpPost]
        public IHttpActionResult example(Loginadm L)
        {
            LoginDAL dal = new LoginDAL();
            int status = dal.ValidateUser(L);

            if (status == 0)
            {
                return Ok(new { status = 401, isSuccess = false, message = "Invalid User", });
            }
            else
            {
                return Ok(new { status = 200, isSuccess = true, message = "User Login successfully" });
            }
        }

        [HttpGet]
        public DataTable Get(int a)
        {
            EmployeeDetailsDAL d = new EmployeeDetailsDAL();
            EmployeeDetails b = new EmployeeDetails();
            b.EmployeeID = a;
            DataTable b1 = d.showDetails(b.EmployeeID);
            return b1;
        }
       
        [HttpPost]
        [Route("insert")]
        public IHttpActionResult insert([FromBody] EmployeeDetails L)
        {
            EmployeeDetailsDAL dal = new EmployeeDetailsDAL();
            dal.add(L);
            return Ok(new { status = 200, isSuccess = true, message = "Employee added successfully" });

        }

        [HttpPost]
        [Route("update")]

        public IHttpActionResult updates(int i, [FromBody] EmployeeDetails L)
        {
            EmployeeDetailsDAL dal = new EmployeeDetailsDAL();
            dal.update(i, L);



            return Ok(new { status = 200, isSuccess = true, message = "Employee updated successfully" });

        }

        [HttpGet]
        public List<EmployeeDetails> showall()
        {
            EmployeeDetailsDAL d = new EmployeeDetailsDAL();
            List<EmployeeDetails> f = d.showAll();
            return f;


        }
    }
}
