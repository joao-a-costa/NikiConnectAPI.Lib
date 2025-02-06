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
            var res = await GetDataModelsAsync<Address>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetBanks()
        {
            var res = await GetDataModelsAsync<Bank>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetContacts()
        {
            var res = await GetDataModelsAsync<Contact>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocuments()
        {
            var res = await GetDataModelsAsync<Document>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocumentHeaders()
        {
            var res = await GetDataDocumentHeadersAsync<DocumentHeader>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocumentHeadersWithParameters()
        {
            var res = await GetDataDocumentHeadersAsync<DocumentHeader>(statusId: 1, typeId: 2,
                aditionalObjects: new System.Collections.Generic.List<string>
                {
                    "entity"
                });
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetDocumentDetails()
        {
            var res = await GetDataModelsAsync<DocumentDetail>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetEntities()
        {
            var res = await GetDataModelsAsync<Entity>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetEntityAccounts()
        {
            var res = await GetDataModelsAsync<EntityAccount>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetEntityBankAccounts()
        {
            var res = await GetDataModelsAsync<EntityBankAccount>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemBarcodeTypes()
        {
            var res = await GetDataModelsAsync<ItemBarcodeType>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemDescriptions()
        {
            var res = await GetDataModelsAsync<ItemDescription>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemFamilies()
        {
            var res = await GetDataModelsAsync<ItemFamily>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemFamilyRates()
        {
            var res = await GetDataModelsAsync<ItemFamilyRate>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemPrices()
        {
            var res = await GetDataModelsAsync<ItemPrice>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemPriceLines()
        {
            var res = await GetDataModelsAsync<ItemPriceLine>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemStocks()
        {
            var res = await GetDataModelsAsync<ItemStock>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItemTypes()
        {
            var res = await GetDataModelsAsync<ItemType>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetUnits()
        {
            var res = await GetDataModelsAsync<Unit>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task GetItems()
        {
            var res = await GetDataModelsAsync<Item>();
            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}