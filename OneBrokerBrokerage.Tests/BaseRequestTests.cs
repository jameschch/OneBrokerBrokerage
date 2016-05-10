using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneBrokerBrokerage;
using NUnit.Framework;
using Moq;
using RestSharp;

namespace OneBrokerBrokerage.Tests
{
    [TestFixture()]
    public class BaseRequestTests
    {

        BaseRequest unit = new BaseRequest(new RestClient());
        Mock<BaseRequest> mock;
        Mock<IRestClient> mockRest = new Mock<IRestClient>();

        public BaseRequestTests()
        {
            mock = new Mock<BaseRequest>(mockRest.Object);
        }

        [Test()]
        public void GetAccountInfoTest()
        {
            var mockResponse = new Mock<IRestResponse<Info>>();
            decimal expected = 123.456m;

            var info = new Info
            {
                response = new InfoResponse
                {
                    balance_btc = expected
                }
            };
            mockResponse.Setup(m => m.Data).Returns(info);

            mockRest.Setup(m => m.ExecuteGetTaskAsync<Info>(It.IsAny<RestRequest>())).Returns(Task.FromResult(mockResponse.Object));

            var actual = mock.Object.GetAccountInfo().Result;

            Assert.AreEqual(expected, actual.balance_btc);

        }

        [Test()]
        public void GetTest()
        {
            throw new NotImplementedException();
        }
    }
}
