using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ValaApplication.Controllers
{
    public class HelloController : ApiController
    {
        // GET api/values
        public String Get()
        {
            return "World!";
        }



       
    }
}
