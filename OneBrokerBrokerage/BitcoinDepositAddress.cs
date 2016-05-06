
using System;

namespace OneBrokerBrokerage
{

    public class BitcoinDepositAddress : BaseResponse
    {

        public BitcoinDepositAddressResponse response { get; set; }

    }

    public class BitcoinDepositAddressResponse
    {
        public string bitcoin_deposit_address { get; set; }
    }
}