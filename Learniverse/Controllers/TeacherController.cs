using BLL.Services;
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

        [HttpGet]
        [Route("api/teacher")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TeacherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/teacher/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, TeacherService.Get(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        // remaining UPDATE and CREATE
        [HttpPost]
        [Route("api/teacher/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, TeacherService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}
