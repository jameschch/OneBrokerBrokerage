

using System;

namespace OneBrokerBrokerage
{

    public class Quotes : BaseResponse
    {

        public QuotesResponse[] response { get; set; }

    }


    public class QuotesResponse
    {
        public string symbol { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public DateTime updated { get; set; }
    }
}