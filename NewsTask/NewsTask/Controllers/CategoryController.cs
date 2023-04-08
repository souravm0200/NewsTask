using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Services;

namespace NewsTask.Controllers
{
    public class CategoryController : ApiController
    {

        [HttpGet]
        [Route("api/category")]
        public HttpResponseMessage GetAllCategories()
        {
            try
            {
                var data = CategoryService.GetAllCategories();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


    }
}