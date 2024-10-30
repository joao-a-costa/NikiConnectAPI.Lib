using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.ServiceModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public async Task CountriesByID()
        {
            var res = await GetDataAsync<Country>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<Country>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Cities()
        {
            var res = await GetDataAsync<City>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CitiesByID()
        {
            var res = await GetDataAsync<City>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<City>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task States()
        {
            var res = await GetDataAsync<State>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task StatesByID()
        {
            var res = await GetDataAsync<State>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<State>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Currencies()
        {
            var res = await GetDataAsync<Currency>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CurrenciesByID()
        {
            var res = await GetDataAsync<Currency>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<Currency>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentMethods()
        {
            var res = await GetDataAsync<PaymentMethod>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentMethodsByID()
        {
            var res = await GetDataAsync<PaymentMethod>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<PaymentMethod>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentTerms()
        {
            var res = await GetDataAsync<PaymentTerm>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentTermsByID()
        {
            var res = await GetDataAsync<PaymentTerm>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<PaymentTerm>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TaxRegions()
        {
            var res = await GetDataAsync<TaxRegion>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TaxRegionsByID()
        {
            var res = await GetDataAsync<TaxRegion>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<TaxRegion>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Pricelines()
        {
            var res = await GetDataAsync<Priceline>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PricelinesByID()
        {
            var res = await GetDataAsync<Priceline>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<Priceline>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TenantUsers()
        {
            var res = await GetDataAsync<TenantUser>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TenantUsersByID()
        {
            var res = await GetDataAsync<TenantUser>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<TenantUser>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Companies()
        {
            var res = await GetDataAsync<Company>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CompaniesByID()
        {
            var res = await GetDataAsync<Company>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataByIDAsync<Company>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}