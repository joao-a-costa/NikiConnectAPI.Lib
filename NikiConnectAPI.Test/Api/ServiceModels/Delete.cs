using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.ServiceModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test.Api.ServiceModels
{
    [TestClass()]
    public class Delete : BaseTester
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
        public async Task Country()
        {
            await DeleteEntity<Country>(App.ListFieldsToIncludeDelete);
        }

        [TestMethod()]
        public async Task City()
        {
            await PostEntity<City>();
        }

        [TestMethod()]
        public async Task State()
        {
            await PostEntity<State>();
        }

        [TestMethod()]
        public async Task Currency()
        {
            await PostEntity<Currency>();
        }

        [TestMethod()]
        public async Task PaymentMethod()
        {
            await PostEntity<PaymentMethod>();
        }

        [TestMethod()]
        public async Task PaymentTerm()
        {
            await PostEntity<PaymentTerm>();
        }

        [TestMethod()]
        public async Task TaxRegion()
        {
            await PostEntity<TaxRegion>();
        }

        [TestMethod()]
        public async Task Priceline()
        {
            await PostEntity<Priceline>();
        }

        //[TestMethod()]
        //public async Task TenantUser()
        //{
        //    await PostEntity<TenantUser>();
        //}

        //[TestMethod()]
        //public async Task Comany()
        //{
        //    await PostEntity<Company>();
        //}

        #endregion
    }
}