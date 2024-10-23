using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NikiConnectAPI.Lib.Models.SyncModels;

namespace NikiConnectAPI.Test.Api.SyncModels
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
        public async Task GetAddresses()
        {
            var res = await GetDataAsync<Address>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetBanks()
        {
            var res = await GetDataAsync<Bank>();
            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}