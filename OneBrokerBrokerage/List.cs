
using System;

namespace OneBrokerBrokerage
{

    public class List : BaseResponse
    {

        public ListResponse[] response { get; set; }

    }

    public class ListResponse
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string category { get; set; }
    }
}