using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NikiConnectAPI.Lib.Helpers;
using NikiConnectAPI.Lib.Models.ServiceModels;
using NikiConnectAPI.Lib.Models.SyncModels;
using NikiConnectAPI.Test.Utilities;

namespace NikiConnectAPI.Test.Api.SyncModels
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
        public async Task Address()
        {
            await PatchEntity<Address>();
        }

        [TestMethod()]
        public async Task Bank()
        {
            await PatchEntity<Bank>();
        }

        [TestMethod()]
        public async Task Contact()
        {
            await PatchEntity<Contact>();
        }

        [TestMethod()]
        public async Task Document()
        {
            await PatchEntity<Document>();
        }

        [TestMethod()]
        public async Task DocumentHeaders()
        {
            await PatchEntity<DocumentHeader>();
        }

        #endregion
    }
}