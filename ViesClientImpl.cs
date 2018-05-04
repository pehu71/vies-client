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
