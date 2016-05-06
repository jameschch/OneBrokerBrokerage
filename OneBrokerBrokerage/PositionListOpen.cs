
using System;

namespace OneBrokerBrokerage
{

    public class PositionListOpen : BaseResponse
    {

        public PositionListOpenResponse[] response { get; set; }

    }

    public class PositionListOpenResponse
    {
        public string position_id { get; set; }
        public string order_id { get; set; }
        public string status { get; set; }
        public string symbol { get; set; }
        public string margin { get; set; }
        public string leverage { get; set; }
        public string direction { get; set; }
        public string entry_price { get; set; }
        public string current_bid { get; set; }
        public string current_ask { get; set; }
        public string profit_loss { get; set; }
        public string profit_loss_percent { get; set; }
        public bool market_close { get; set; }
        public string stop_loss { get; set; }
        public object take_profit { get; set; }
    }
}
