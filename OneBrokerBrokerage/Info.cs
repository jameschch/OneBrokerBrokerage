
using System;

namespace OneBrokerBrokerage
{

    public class Info : BaseResponse
    {

        public InfoResponse response { get; set; }

    }

    public class InfoResponse
    {
        public string username { get; set; }
        public decimal balance_btc { get; set; }
        public string email { get; set; }
        public string deposits_unconfirmed_btc { get; set; }
        public DateTime registered_since { get; set; }
    }

}