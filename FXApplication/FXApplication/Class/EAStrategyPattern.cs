using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXApplication.Class
{
    public class EAStrategyPattern
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string accountNumber { get; set; }
        public EAChartGroup[] _EAChartGroup { get; set; }
    }
}