﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitApplication.Controllers
{
    public class DefaultController : ApiController
    {//this is the post method
        public string Post()
        {
            return "Good morning have a nice day";
        }
    }
}
