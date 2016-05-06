

using System;

namespace OneBrokerBrokerage
{

    public class Edit : BaseResponse
    {

        public EditResponse response { get; set; }

    }

    public class EditResponse
    {
        public string position_id { get; set; }
        public bool market_close { get; set; }
        public string stop_loss { get; set; }
        public object take_profit { get; set; }
    }
}