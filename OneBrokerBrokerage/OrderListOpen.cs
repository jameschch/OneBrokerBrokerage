
using System;

namespace OneBrokerBrokerage
{

    public class OrderListOpen : BaseResponse
    {

        public OrderListOpenResponse[] response { get; set; }

    }

    public class OrderListOpenResponse
    {
        public string order_id { get; set; }
        public string symbol { get; set; }
        public string margin { get; set; }
        public string leverage { get; set; }
        public string direction { get; set; }
        public string order_type { get; set; }
        public string order_type_parameter { get; set; }
        public string stop_loss { get; set; }
        public string take_profit { get; set; }
        public DateTime created { get; set; }
    }
}