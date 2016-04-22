using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HGPS.Core;

namespace HGPS.App.Controllers
{
    public class LocationController : HgpsControllerBase
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4" };
        }        
    }
}