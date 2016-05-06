using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBrokerBrokerage
{

    public abstract class BaseResponse
    {
        public DateTime server_time { get; set; }
        public bool error { get; set; }
        public bool warning { get; set; }

    }

}
