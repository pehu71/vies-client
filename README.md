## VIES Registry Client for .NET

This repo contains simple .NET Client to fetch just the very basic info based on VAT number from VIES Registry.

### Implementation
The main file is `ViesClientImpl.cs` which is as simple as follows:

````C#
using System;
using System.Threading.Tasks;
using ViesClient.CheckVatService;
using ViesClient.Requests;
using ViesClient.Selectors;

namespace ViesClient
{
    public class ViesClientImpl
    {
        public static async Task<ViesSelector> CheckVatNumber(ViesRequest request)
        {
            checkVatRequestBody body = new checkVatRequestBody(request.CountryCode, request.VatNumber);
            checkVatRequest viesRequest = new checkVatRequest(body);
            checkVatResponseBody responseBody = null;

            try
            {
                using (checkVatPortTypeClient client = new checkVatPortTypeClient())
                {
                    checkVatResponse viesResponse = await client.checkVatAsync(viesRequest);
                    responseBody = viesResponse.Body;
                }
                return new ViesSelector()
                {
                    Address = responseBody.address,
                    CountryCode = responseBody.countryCode,
                    Name = responseBody.name,
                    RequestDate = responseBody.requestDate,
                    Valid = responseBody.valid,
                    VatNumber = responseBody.vatNumber
                };
            }
            catch (Exception ex)
            {
                // todo: you can log somewhere
                return null;
            }
            
        }
    }
}
````

Just copy and include in your .NET project. This one has been tested on .NET 4.5. There is one NUGET you might need for decorating mapping classes - since this code has been written for use in Web API controller.
You can throw it out, if you wish.

### Unit Test
There is also a UT file in Test folder called `ViesTest.cs`. Which goes like this:

````C#
using System.Threading.Tasks;
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
````

There is a bit of proprietary assy reference to `Microsoft.VisualStudio.TestTools.UnitTesting` you might struggle a bit with.

> Do not forget to add **proper country code** and the **8-digit VAT number** into the UT code.

And that's all.

