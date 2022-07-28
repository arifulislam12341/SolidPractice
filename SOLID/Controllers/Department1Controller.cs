using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SOLID.Controllers
{
    public class Department1Controller : ApiController
    {
        [Route("api/department/departmentinfo")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data = DepartmentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/department/departmentcreate")]

        public HttpResponseMessage Create(DepartmentModel obj)
        {
            DepartmentService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
