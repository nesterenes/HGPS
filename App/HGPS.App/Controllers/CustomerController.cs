using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HGPS.Core;
using HGPS.Core.Services;

namespace HGPS.App.Controllers
{
    public class CustomerController : HgpsControllerBase
    {
        private CustomerService service()
        {
            return new CustomerService();
        }

        // GET api/values
        public HttpResponseMessage Get()
        {
            try
            {
                var rtn = service().GetCustomers();
                return ResponseOk(rtn);
            }
            catch (System.Exception e)
            {
                // Unsupported mapping error
                return ResponseOk();
            }
        }
    }
}