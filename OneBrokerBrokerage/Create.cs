
using System;

namespace OneBrokerBrokerage
{

    public class Create : BaseResponse
    {

        public CreateResponse response { get; set; }

    }

    public class CreateResponse
    {
        public string order_id { get; set; }
        public string symbol { get; set; }
        public string margin { get; set; }
        public string leverage { get; set; }
        public string direction { get; set; }
        public string order_type { get; set; }
        public string order_type_parameter { get; set; }
        public object stop_loss { get; set; }
        public object take_profit { get; set; }
        public DateTime created { get; set; }
    }
}