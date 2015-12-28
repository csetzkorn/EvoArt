using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using EvoArt.WebApi.Models;

namespace EvoArt.WebApi.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        [Route("Test1")]
        [HttpGet]
        public IHttpActionResult Test1()
        {
            IList<PayLoad> payLoadList = new List<PayLoad>();
            payLoadList.Add(new PayLoad());
            payLoadList.Add(new PayLoad());
            payLoadList.Add(new PayLoad());
            payLoadList.Add(new PayLoad());

            return Ok(payLoadList);
        }

        [Route("Test2")]
        [HttpPost]
        public IHttpActionResult Test2([FromBody] Guid guid)
        {
            return Ok();
        }
    }
}
