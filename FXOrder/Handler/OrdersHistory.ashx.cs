using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXOrder.Handler
{
    /// <summary>
    /// Summary description for OrdersHistory
    /// </summary>
    public class OrdersHistory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.Write(Class.Order.GetOrdersHistory());
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