using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEBWarmup.MulServiceReference;

namespace SEBWarmup.Controllers.API
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult get(int a , int b)
        {

            MulServiceClient MSC = new MulServiceClient("BasicHttpBinding_IMulService");

            var result = MSC.Mul(a,b);


            return Ok($"Can ! {result.ToString()}");

        }




        [Route("api/Tes")]
        //http://localhost:1589/api/Test
        [HttpGet]
        public IHttpActionResult testapi()
        {


           
          MulServiceClient MSC = new MulServiceClient("BasicHttpBinding_IMulService");

            //var result 

            return Ok();

        }


    }
}
