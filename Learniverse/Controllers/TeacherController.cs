using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Learniverse.Controllers
{
    public class TeacherController : ApiController
    {
        /// sfdfsdf
        /// dfsdf
        /// dsfdsfsdfsd
        /// HttpGet]
        [Route("api/products")]
        public HttpResponseMessage Get()
        {
            try
            {
                //var data = ProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}
