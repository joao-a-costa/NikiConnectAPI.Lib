using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.ServiceModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test.Api.ServiceModels
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
        public async Task Countries()
        {
            var res = await GetDataAsync<Country>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Cities()
        {
            var res = await GetDataAsync<City>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task States()
        {
            var res = await GetDataAsync<State>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Currencies()
        {
            var res = await GetDataAsync<Currency>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentMethods()
        {
            var res = await GetDataAsync<PaymentMethod>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentTerms()
        {
            var res = await GetDataAsync<PaymentTerm>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TaxRegions()
        {
            var res = await GetDataAsync<TaxRegion>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Pricelines()
        {
            var res = await GetDataAsync<Priceline>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TenantUsers()
        {
            var res = await GetDataAsync<TenantUser>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Companies()
        {
            var res = await GetDataAsync<Company>();
            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}