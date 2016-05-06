using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneBrokerBrokerage
{
    public class BaseRequest
    {

        string info = "https://1broker.com/api/v1/account/info.php?token=%APITOKEN%&pretty=1";
        string overview = "https://1broker.com/api/v1/account/overview.php?token=%APITOKEN%&pretty=1";
        string bitcoin_deposit_address = "https://1broker.com/api/v1/account/bitcoin_deposit_address.php?token=%APITOKEN% &pretty=1";
        string order_list_open = "https://1broker.com/api/v1/order/list_open.php?token=%APITOKEN% &pretty=1";
        string create = "https://1broker.com/api/v1/order/create.php? symbol=GOLD &margin=0.2 &direction=long &leverage=3 &order_type=limit &order_type_parameter=950 &referral_id=1337 &token=%APITOKEN% &pretty=1";

        string cancel = "https://1broker.com/api/v1/order/cancel.php? order_id=210123 &token=%APITOKEN% &pretty=1";
        string position_list_open = "https://1broker.com/api/v1/position/list_open.php?token=%APITOKEN%";
        string list_history = "https://1broker.com/api/v1/position/list_history.php? limit=2 &offset=4 &token=%APITOKEN% &pretty=1";
        string edit = "https://1broker.com/api/v1/position/edit.php? position_id=1031546 &market_close=true &token=%APITOKEN% &pretty=1";
        string list = "https://1broker.com/api/v1/market/list.php?token=%APITOKEN%&pretty=1";
        string detail = "https://1broker.com/api/v1/market/detail.php? symbol=GOLD &token=%APITOKEN% &pretty=1";
        string quotes = "https://1broker.com/api/v1/market/quotes.php? symbols=GOLD,EURUSD &token=%APITOKEN% &pretty=1";
        string get_bars = "https://1broker.com/api/v1/market/get_bars.php? symbol=GOLD &from=1388534400 &to=1451520010 &resolution=60 &token=%APITOKEN% &pretty=1";

        string apiToken = "";

        public async Task<InfoResponse> GetAccountInfo()
        {
            return (await Get<Info>(info)).response;
        }

        public async Task<T> Get<T>(string url)
        {
            url = url.Replace("%APITOKEN%", apiToken);
            var client = new RestClient(url);
            var response = await client.ExecuteGetTaskAsync<T>(new RestRequest());
            return response.Data;
        }

    }
}
