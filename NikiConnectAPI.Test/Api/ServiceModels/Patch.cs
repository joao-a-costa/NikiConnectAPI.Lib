using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.ServiceModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NikiConnectAPI.Test.Api.ServiceModels
{
    [TestClass()]
    public class Patch : BaseTester
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
            await PatchEntity<Country>();
        }

        [TestMethod()]
        public async Task City()
        {
            await PatchEntity<City>();
        }

        [TestMethod()]
        public async Task State()
        {
            await PatchEntity<State>();
        }

        [TestMethod()]
        public async Task Currency()
        {
            await PatchEntity<Currency>();
        }

        [TestMethod()]
        public async Task PaymentMethod()
        {
            await PatchEntity<PaymentMethod>();
        }

        [TestMethod()]
        public async Task PaymentTerm()
        {
            await PatchEntity<PaymentTerm>();
        }

        [TestMethod()]
        public async Task TaxRegion()
        {
            await PatchEntity<TaxRegion>();
        }

        [TestMethod()]
        public async Task Priceline()
        {
            await PatchEntity<Priceline>();
        }

        //[TestMethod()]
        //public async Task TenantUser()
        //{
        //    await PatchEntity<TenantUser>();
        //}

        //[TestMethod()]
        //public async Task Comany()
        //{
        //    await PatchEntity<Company>();
        //}

        #endregion
    }
}