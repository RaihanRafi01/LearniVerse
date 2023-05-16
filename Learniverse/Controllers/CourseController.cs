using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Learniverse.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CourseController : ApiController
    {
        [HttpGet]
        [Route("api/course")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CourseService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
        
        [HttpGet]
        [Route("api/course/{course}")]
        public HttpResponseMessage Get(string course)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, CourseService.Get(course));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/course/add")]
        public HttpResponseMessage Add(CourseDTO obj)
        {
            try
            {
                var res = CourseService.Create(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = obj });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }

        [HttpPost]
        [Route("api/course/update")]
        public HttpResponseMessage Update(CourseDTO obj)
        {
            try
            {
                var res = CourseService.Update(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Updated", Data = obj });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }

        [HttpPost]
        [Route("api/course/delete/{id}")]
        public HttpResponseMessage Delete(string id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, CourseService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/course/count")]
        public HttpResponseMessage Count()
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, CourseService.Count());
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}
