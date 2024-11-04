using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.Flyers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NikiConnectAPI.Test.Api.Flyers
{
    [TestClass()]
    public class Get : BaseTester
    {
        #region "Public Methods"

        [TestInitialize()]
        public async Task Initialize()
        {
            AccessToken = await GetAccessTokenAsync();

            if (!string.IsNullOrEmpty(AccessToken))
                Header = CreateHeader(AccessToken);

            Assert.IsTrue(Header != null);
        }

        [TestMethod()]
        public async Task Flyers()
        {
            var res = await GetDataFlyersAsync<Flyer>();
            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}