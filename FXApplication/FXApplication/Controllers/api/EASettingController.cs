using FXApplication.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FXApplication.Controllers.api
{
    public class EASettingController : ApiController
    {
       

        [HttpPost]
        public EAUser getUserPatterns([FromBody]User user) {
        //public EAUser getUserPatterns() {
            return new EAUser()
            {
                UserID = user.user_id,
                Username = user.token,
                _EAStrategyPattern = new EAStrategyPattern[] { new EAStrategyPattern {
                            accountNumber = "12345678",
                            name = "Pattern For Win",
                            desc = "This pattern is made for test",
                            _EAChartGroup = new EAChartGroup[]
                            {
                                new EAChartGroup()
                                {
                                    name = "Chart Group 01",
                                    desc = "Chart Group descripation",
                                    _EAChart = new EAChart[]{
                                        new EAChart()
                                        {
                                            name = "Chart 01",
                                            desc = "Chart Descripation",
                                            _EAOHLC = new EAOHLC[]{
                                                    new EAOHLC() {
                                                            open = 133.08,
                                                            high = 133.82,
                                                            low = 132.75,
                                                            close = 133.29,
                                                            volume = 23035400,
                                                            date = "1486996200000"
                                                    },
                                                    new EAOHLC() {
                                                            open = 133.47,
                                                            high = 135.09,
                                                            low = 133.25,
                                                            close = 135.02,
                                                            volume = 33226200,
                                                            date = "1487082600000"
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    
        }
 
        
        public class User {
            public string user_id { get; set; }
            public string token { get; set; }
        }

    }
}