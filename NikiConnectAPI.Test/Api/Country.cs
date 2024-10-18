using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test
{
    [TestClass()]
    public class Country
    {
        [TestMethod()]
        public async Task Get()
        {
            var token = await Lib.Api.Auth.CreateToken($"{App._Url}{App._UrlVersion}{App._UrlToken}", App._UrlUserAgent, App._ClientID, App._ClientSecreat);

            if (!string.IsNullOrEmpty(token?.Item1?.AccessToken))
            {
                var header = new Lib.Models.Header
                {
                    Authorization = $"Bearer {token.Item1.AccessToken}",
                    XCompanyID = App._XCompany,
                    XTenant = App._XTenant,
                    XVersion = App._XVersion
                };

                var res = await Lib.Api.Country.Get($"{App._Url}{App._UrlVersion}{App._UrlRemoteApiClient}", header);

                Assert.IsTrue(res?.Item1?.Data?.Count != null);
            }

            Assert.Fail();
        }
    }
}