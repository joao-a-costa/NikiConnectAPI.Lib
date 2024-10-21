using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test
{
    [TestClass()]
    public class Auth
    {
        [TestMethod()]
        public async Task CreateTokenAuth()
        {
            var res = await Lib.Api.Auth.CreateToken($"{App._Url}{App._UrlVersion}{App._UrlToken}", App._UrlUserAgent, App._ClientID, App._ClientSecret);

            Assert.IsTrue(!string.IsNullOrEmpty(res?.Token?.AccessToken));
        }
    }
}