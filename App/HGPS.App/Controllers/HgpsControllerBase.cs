using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace HGPS.App.Controllers
{
    public class HgpsControllerBase : ApiController
    {


        protected HttpResponseMessage ResponseCreated<T>(T model)
        {
            return Response(HttpStatusCode.Created, model);
        }

        protected HttpResponseMessage ResponseUpdated<T>(T model)
        {
            return Response(HttpStatusCode.OK, model);
        }

        protected HttpResponseMessage ResponseOk<T>(T model)
        {
            return Response(HttpStatusCode.OK, model);
        }

        protected HttpResponseMessage ResponseOk()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        protected HttpResponseMessage ResponseBadRequest(string message)
        {
            return Response(HttpStatusCode.BadRequest, message);
        }

        protected HttpResponseMessage ResponseError(string message)
        {
            return Response(HttpStatusCode.InternalServerError, message);
        }

        protected HttpResponseMessage Response<T>(HttpStatusCode status, T model)
        {
            return new HttpResponseMessage(status) { Content = new ObjectContent(typeof(T), model, new JsonMediaTypeFormatter()) };
        }
    }
}
