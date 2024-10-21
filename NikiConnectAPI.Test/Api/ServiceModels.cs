using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test
{
    [TestClass()]
    public class ServiceModels
    {
        #region "Private Methods"

        private async Task<string> GetAccessTokenAsync()
        {
            var token = await Lib.Api.Auth.CreateToken(
                $"{App._Url}{App._UrlVersion}{App._UrlToken}",
                App._UrlUserAgent,
                App._ClientID,
                App._ClientSecret
            );

            return token?.Token?.AccessToken;
        }

        private Lib.Models.Header CreateHeader(string accessToken)
        {
            return new Lib.Models.Header
            {
                Authorization = $"Bearer {accessToken}",
                XCompanyID = App._XCompany,
                XTenant = App._XTenant,
                XVersion = App._XVersion
            };
        }

        private async Task<bool> FetchDataAsync<T>() where T : class
        {
            var accessToken = await GetAccessTokenAsync();
            if (string.IsNullOrEmpty(accessToken)) return false;

            var header = CreateHeader(accessToken);
            var res = await Lib.Api.DataFetcher.Get<T>($"{App._Url}{App._UrlVersion}{App._UrlRemoteApiClient}", header);
            return res?.DataResult?.Data?.Count != null;
        }

        #endregion

        #region "Public Methods"

        [TestMethod()]
        public async Task GetCountries()
        {
            var success = await FetchDataAsync<Lib.Models.Country>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetCities()
        {
            var success = await FetchDataAsync<Lib.Models.City>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetStates()
        {
            var success = await FetchDataAsync<Lib.Models.State>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetCurrencies()
        {
            var success = await FetchDataAsync<Lib.Models.Currency>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetPaymentMethods()
        {
            var success = await FetchDataAsync<Lib.Models.PaymentMethod>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetPaymentTerms()
        {
            var success = await FetchDataAsync<Lib.Models.PaymentTerm>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetTaxRegions()
        {
            var success = await FetchDataAsync<Lib.Models.TaxRegion>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetPricelines()
        {
            var success = await FetchDataAsync<Lib.Models.Priceline>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetTenantUsers()
        {
            var success = await FetchDataAsync<Lib.Models.TenantUser>();
            Assert.IsTrue(success);
        }

        [TestMethod()]
        public async Task GetCompanies()
        {
            var success = await FetchDataAsync<Lib.Models.Company>();
            Assert.IsTrue(success);
        }

        #endregion
    }
}