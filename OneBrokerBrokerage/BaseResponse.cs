using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBrokerBrokerage
{

    public abstract class BaseResponse : OneBrokerBrokerage.IBaseResponse
    {
        public DateTime server_time { get; set; }
        public bool error { get; set; }
        public bool warning { get; set; }
        public string error_code { get; set; }
        public string error_message { get; set; }
        public string warning_message { get; set; }
    }

}
