using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FXApplication.Class
{
    public class EAUser
    {  
        public string UserID {get;set; }
        public string Username { get; set; }
        public EAStrategyPattern[] _EAStrategyPattern { get; set; }
    }
}