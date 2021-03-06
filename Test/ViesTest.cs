﻿using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViesClient;
using ViesClient.Requests;
using ViesClient.Selectors;

namespace UnitTests
{
    [TestClass]
    public class ViesTest
    {
        [TestMethod]
        public async Task CheckVatNumberTest()
        {
            ViesRequest request = new ViesRequest() { CountryCode = "CZ", VatNumber = "add-8-digit-number-here" };
            var result = await ViesClientImpl.CheckVatNumber(request);
            Assert.IsTrue(result != null && result is ViesSelector);
        }
    }
}
