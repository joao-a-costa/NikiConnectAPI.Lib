using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test
{
    [TestClass()]
    public class ServiceModels
    {
        [TestMethod()]
        public async Task GetCountries()
        {
            var success = false;
            var token = await Lib.Api.Auth.CreateToken($"{App._Url}{App._UrlVersion}{App._UrlToken}", App._UrlUserAgent, App._ClientID, App._ClientSecret);

            if (!string.IsNullOrEmpty(token?.Token?.AccessToken))
            {
                var header = new Lib.Models.Header
                {
                    Authorization = $"Bearer {token.Token.AccessToken}",
                    XCompanyID = App._XCompany,
                    XTenant = App._XTenant,
                    XVersion = App._XVersion
                };

                var res = await Lib.Api.DataFetcher.Get<Lib.Models.Country>($"{App._Url}{App._UrlVersion}{App._UrlRemoteApiClient}", header);

                success = res?.DataResult?.Data?.Count != null;
                
            }

            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetCurrencies()
        {
            var success = false;
            var token = await Lib.Api.Auth.CreateToken($"{App._Url}{App._UrlVersion}{App._UrlToken}", App._UrlUserAgent, App._ClientID, App._ClientSecret);

            if (!string.IsNullOrEmpty(token?.Token?.AccessToken))
            {
                var header = new Lib.Models.Header
                {
                    Authorization = $"Bearer {token.Token.AccessToken}",
                    XCompanyID = App._XCompany,
                    XTenant = App._XTenant,
                    XVersion = App._XVersion
                };

                var res = await Lib.Api.DataFetcher.Get<Lib.Models.Currency>($"{App._Url}{App._UrlVersion}{App._UrlRemoteApiClient}", header);

                success = res?.DataResult?.Data?.Count != null;

            }

            Assert.IsTrue(success);
        }
    }
}