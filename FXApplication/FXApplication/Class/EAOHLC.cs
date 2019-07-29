using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXApplication.Class
{
    public class EAOHLC
    {
        public string date { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public double volume { get; set; }
    }
}