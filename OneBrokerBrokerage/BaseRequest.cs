using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBrokerBrokerage
{
    public class BaseRequest : OneBrokerBrokerage.IBaseRequest
    {

        string info = "https://1broker.com/api/v1/account/info.php?token=%APITOKEN%&pretty=1";
        string overview = "https://1broker.com/api/v1/account/overview.php?token=%APITOKEN%&pretty=1";
        string bitcoin_deposit_address = "https://1broker.com/api/v1/account/bitcoin_deposit_address.php?token=%APITOKEN%&pretty=1";
        string order_list_open = "https://1broker.com/api/v1/order/list_open.php?token=%APITOKEN%&pretty=1";
        string create = "https://1broker.com/api/v1/order/create.php?symbol=GOLD&margin=0.2&direction=long&leverage=3&order_type=limit&order_type_parameter=950&referral_id=1337&token=%APITOKEN%&pretty=1";
        string cancel = "https://1broker.com/api/v1/order/cancel.php?order_id=210123&token=%APITOKEN%&pretty=1";
        string position_list_open = "https://1broker.com/api/v1/position/list_open.php?token=%APITOKEN%";
        string list_history = "https://1broker.com/api/v1/position/list_history.php?limit=2&offset=4&token=%APITOKEN%&pretty=1";
        string edit = "https://1broker.com/api/v1/position/edit.php?position_id=1031546&market_close=true&token=%APITOKEN%&pretty=1";
        string list = "https://1broker.com/api/v1/market/list.php?token=%APITOKEN%&pretty=1";
        string detail = "https://1broker.com/api/v1/market/detail.php?symbol=GOLD&token=%APITOKEN%&pretty=1";
        string quotes = "https://1broker.com/api/v1/market/quotes.php?symbols=GOLD,EURUSD&token=%APITOKEN%&pretty=1";
        string get_bars = "https://1broker.com/api/v1/market/get_bars.php?symbol=GOLD&from=1388534400&to=1451520010&resolution=60&token=%APITOKEN%&pretty=1";

        string apiToken = "";

        IRestClient _restClient;

        public BaseRequest(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<InfoResponse> GetAccountInfo()
        {
            return (await Get<Info>(info)).response;
        }

        public async Task<OverviewResponse> GetAccountOverview()
        {
            return (await Get<Overview>(overview)).response;
        }

        public async Task<BitcoinDepositAddressResponse> GetAccountBitcoinDepositAddress()
        {
            return (await Get<BitcoinDepositAddress>(bitcoin_deposit_address)).response;
        }

        public async Task<T> Get<T>(string url) where T : BaseResponse
        {
            url = url.Replace("%APITOKEN%", apiToken);
            _restClient.BaseUrl = new Uri(url);
            var response = await _restClient.ExecuteGetTaskAsync<T>(new RestRequest());

            if (response.Data.error)
            {
                throw new Exception("Brokerage returned error: " + response.Data.error_message);
            }

            return response.Data;
        }

    }
}
