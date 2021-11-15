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

namespace HRProject.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]

    public class LoginFormController : ApiController
    {
        [HttpPost]

        public IHttpActionResult LoginAdmin([FromBody]Loginadmin L)
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
        // GET: api/LoginForm
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/LoginForm/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/LoginForm
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/LoginForm/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/LoginForm/5
        //public void Delete(int id)
        //{
        //}
    }
}
