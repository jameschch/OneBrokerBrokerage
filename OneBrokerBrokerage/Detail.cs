

using System;

namespace OneBrokerBrokerage
{

    public class Detail : BaseResponse
    {

        public DetailResponse response { get; set; }

    }


    public class DetailResponse
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string maximum_leverage { get; set; }
        public string limit_btc { get; set; }
        public string overnight_charge_long_percent { get; set; }
        public string overnight_charge_short_percent { get; set; }
    }
}