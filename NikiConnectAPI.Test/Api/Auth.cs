using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test.Api
{
    [TestClass()]
    public class Auth
    {
        [TestMethod()]
        public async Task CreateTokenAuth()
        {
            var app = new App();
            var res = await Lib.Api.Auth.CreateToken($"{app.Url}{app.UrlVersion}{app.UrlToken}", app.UrlUserAgent, app.ClientID, app.ClientSecret);

            Assert.IsTrue(!string.IsNullOrEmpty(res?.Token?.AccessToken));
        }
    }
}