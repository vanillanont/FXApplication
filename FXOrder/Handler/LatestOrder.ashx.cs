using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXOrder.Handler
{
    /// <summary>
    /// Summary description for LatestOrder
    /// </summary>
    public class LatestOrder : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.Write(Class.Order.GetLatestOrder());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}