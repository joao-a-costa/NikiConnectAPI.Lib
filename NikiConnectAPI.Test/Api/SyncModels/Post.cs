using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NikiConnectAPI.Lib.Helpers;
using NikiConnectAPI.Lib.Models.SyncModels;
using NikiConnectAPI.Test.Utilities;

namespace NikiConnectAPI.Test.Api.SyncModels
{
    [TestClass()]
    public class Post : BaseTester
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
        public async Task Address()
        {
            await PostEntity<Address>();
        }

        [TestMethod()]
        public async Task Bank()
        {
            await PostEntity<Bank>();
        }

        [TestMethod()]
        public async Task Contact()
        {
            await PostEntity<Contact>();
        }

        [TestMethod()]
        public async Task Document()
        {
            await PostEntity<Document>();
        }

        [TestMethod()]
        public async Task DocumentHeader()
        {
            await PostEntity<DocumentHeader>();
        }

        [TestMethod()]
        public async Task DocumentDetail()
        {
            await PostEntity<DocumentDetail>();
        }

        [TestMethod()]
        public async Task Entity()
        {
            await PostEntity<Entity>();
        }

        [TestMethod()]
        public async Task EntityAccount()
        {
            await PostEntity<EntityAccount>();
        }

        [TestMethod()]
        public async Task EntityBankAccount()
        {
            await PostEntity<EntityBankAccount>();
        }

        #endregion
    }
}