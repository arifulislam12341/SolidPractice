using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLID.Controllers
{
    public class StudentController : ApiController
    {

        [Route("api/student/studentinfo")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data); 

        }
    }
}
