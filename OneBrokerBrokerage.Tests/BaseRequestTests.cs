using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneBrokerBrokerage;
using NUnit.Framework;

namespace OneBrokerBrokerage.Tests
{
    [TestFixture()]
    public class BaseRequestTests
    {

        BaseRequest unit = new BaseRequest();

        [Test()]
        public void GetAccountInfoTest()
        {
            var actual = unit.GetAccountInfo().Result;

            throw new NotImplementedException();
        }

        [Test()]
        public void GetTest()
        {
            throw new NotImplementedException();
        }
    }
}
