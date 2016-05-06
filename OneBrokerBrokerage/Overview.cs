
using System;

namespace OneBrokerBrokerage
{

    public class Overview : BaseResponse
    {

        public OverviewResponse response { get; set; }

    }

    public class OverviewResponse
    {
        public string username { get; set; }
        public string email { get; set; }
        public string deposits_unconfirmed_btc { get; set; }
        public string balance_btc { get; set; }
        public string orders_worth_btc { get; set; }
        public string positions_worth_btc { get; set; }
        public string net_worth_btc { get; set; }
        public Orders_Open[] orders_open { get; set; }
        public Positions_Open[] positions_open { get; set; }
    }

    public class Orders_Open
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

    public class Positions_Open
    {
        public string position_id { get; set; }
        public string order_id { get; set; }
        public string symbol { get; set; }
        public string margin { get; set; }
        public string leverage { get; set; }
        public string direction { get; set; }
        public string entry_price { get; set; }
        public string current_bid { get; set; }
        public string current_ask { get; set; }
        public string profit_loss { get; set; }
        public string profit_loss_percent { get; set; }
        public string value { get; set; }
        public bool market_close { get; set; }
        public string stop_loss { get; set; }
        public object take_profit { get; set; }
        public DateTime created { get; set; }
    }
}