using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXApplication.Class
{
    public class EAChart
    {
        public string name { get; set; }
        public string desc { get; set; }
        public EAOHLC[] _EAOHLC { get; set; }
    }
}