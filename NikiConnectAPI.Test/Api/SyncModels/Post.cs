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

        #endregion
    }
}