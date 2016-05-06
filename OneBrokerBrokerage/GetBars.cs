

using System;

namespace OneBrokerBrokerage
{

    public class GetBars : BaseResponse
    {

        public GetBarsResponse[] response { get; set; }

    }


    public class GetBarsResponse
    {
        public string time { get; set; }
        public string o { get; set; }
        public string h { get; set; }
        public string l { get; set; }
        public string c { get; set; }
    }
}