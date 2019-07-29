using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXOrder.Handler
{
    /// <summary>
    /// Summary description for Orders
    /// </summary>
    public class Orders : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.Write(Class.Order.GetOrders());
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