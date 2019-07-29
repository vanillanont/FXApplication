using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXApplication.Class
{
    public class EAChartGroup
    {
        public string name { get; set; }
        public string desc { get; set; }
        public EAChart[] _EAChart { get; set; }
    }
}