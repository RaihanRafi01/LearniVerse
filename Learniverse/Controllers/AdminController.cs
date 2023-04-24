using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Learniverse.Controllers
{
    public class AdminController : ApiController
    {
        [HttpGet]
        [Route("api/admin")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
        [HttpGet]
        [Route("api/admin/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, AdminService.Get(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpPost]
        [Route("api/admin/add")]
        public HttpResponseMessage Add(AdminDTO obj)
        {
            try
            {
                var res = AdminService.Create(obj);
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
        [Route("api/admin/update")]
        public HttpResponseMessage Update(AdminDTO obj)
        {
            try
            {
                var res = AdminService.Update(obj);
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
        [Route("api/admin/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, AdminService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}
