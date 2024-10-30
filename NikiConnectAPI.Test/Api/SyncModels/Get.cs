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

        [TestMethod()]
        public async Task GetContacts()
        {
            var res = await GetDataAsync<Contact>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocuments()
        {
            var res = await GetDataAsync<Document>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocumentHeaders()
        {
            var res = await GetDataAsync<DocumentHeader>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocumentDetails()
        {
            var res = await GetDataAsync<DocumentDetail>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetEntities()
        {
            var res = await GetDataAsync<Entity>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetEntityAccounts()
        {
            var res = await GetDataAsync<EntityAccount>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetEntityBankAccounts()
        {
            var res = await GetDataAsync<EntityBankAccount>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemBarcodeTypes()
        {
            var res = await GetDataAsync<ItemBarcodeType>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemDescriptions()
        {
            var res = await GetDataAsync<ItemDescription>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemFamilies()
        {
            var res = await GetDataAsync<ItemFamily>();
            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}