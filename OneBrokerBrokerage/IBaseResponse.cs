using System;
namespace OneBrokerBrokerage
{
    interface IBaseResponse
    {
        bool error { get; set; }
        string error_code { get; set; }
        string error_message { get; set; }
        DateTime server_time { get; set; }
        bool warning { get; set; }
        string warning_message { get; set; }
    }
}
