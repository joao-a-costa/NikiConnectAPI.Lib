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
            var res = await GetDataModelsAsync<Country>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CountriesByID()
        {
            var res = await GetDataModelsAsync<Country>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<Country>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Cities()
        {
            var res = await GetDataModelsAsync<City>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CitiesByID()
        {
            var res = await GetDataModelsAsync<City>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<City>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task States()
        {
            var res = await GetDataModelsAsync<State>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task StatesByID()
        {
            var res = await GetDataModelsAsync<State>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<State>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Currencies()
        {
            var res = await GetDataModelsAsync<Currency>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CurrenciesByID()
        {
            var res = await GetDataModelsAsync<Currency>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<Currency>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentMethods()
        {
            var res = await GetDataModelsAsync<PaymentMethod>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentMethodsByID()
        {
            var res = await GetDataModelsAsync<PaymentMethod>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<PaymentMethod>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentTerms()
        {
            var res = await GetDataModelsAsync<PaymentTerm>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PaymentTermsByID()
        {
            var res = await GetDataModelsAsync<PaymentTerm>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<PaymentTerm>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TaxRegions()
        {
            var res = await GetDataModelsAsync<TaxRegion>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TaxRegionsByID()
        {
            var res = await GetDataModelsAsync<TaxRegion>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<TaxRegion>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Pricelines()
        {
            var res = await GetDataModelsAsync<Priceline>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task PricelinesByID()
        {
            var res = await GetDataModelsAsync<Priceline>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<Priceline>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TenantUsers()
        {
            var res = await GetDataModelsAsync<TenantUser>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task TenantUsersByID()
        {
            var res = await GetDataModelsAsync<TenantUser>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<TenantUser>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task Companies()
        {
            var res = await GetDataModelsAsync<Company>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task CompaniesByID()
        {
            var res = await GetDataModelsAsync<Company>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataModelsByIDAsync<Company>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}