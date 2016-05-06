

using System;

namespace OneBrokerBrokerage
{

    public class ListHistory : BaseResponse
    {

        public ListHistoryResponse[] response { get; set; }

    }
    public class ListHistoryResponse
    {
        public string position_id { get; set; }
        public string order_id { get; set; }
        public string symbol { get; set; }
        public string margin { get; set; }
        public string leverage { get; set; }
        public string direction { get; set; }
        public string entry_price { get; set; }
        public string exit_price { get; set; }
        public string profit_loss { get; set; }
        public string profit_loss_percent { get; set; }
        public string value { get; set; }
        public DateTime created { get; set; }
        public DateTime closed { get; set; }
    }
}