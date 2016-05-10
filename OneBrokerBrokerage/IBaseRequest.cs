using System;
namespace OneBrokerBrokerage
{
    interface IBaseRequest
    {
        System.Threading.Tasks.Task<T> Get<T>(string url) where T : BaseResponse;
        System.Threading.Tasks.Task<BitcoinDepositAddressResponse> GetAccountBitcoinDepositAddress();
        System.Threading.Tasks.Task<InfoResponse> GetAccountInfo();
        System.Threading.Tasks.Task<OverviewResponse> GetAccountOverview();
    }
}
