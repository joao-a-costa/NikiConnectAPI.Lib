using System;
using System.Threading.Tasks;
using NikiConnectAPI.Lib.Models.Flyers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace NikiConnectAPI.Test.Api.Flyers
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
        public async Task Flyers()
        {
            var res = await GetDataFlyersAsync<Flyer>();
            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task FlyersByID()
        {
            var res = await GetDataFlyersAsync<Flyer>();

            if (res?.DataResult != null)
            {
                var randomIndex = new Random().Next(0, res.DataResult.Data.Count);
                var resByID = await GetDataFlyersByIDAsync<Flyer>(res.DataResult.Data[randomIndex]?.Id.ToString());
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        [TestMethod()]
        public async Task FlyersByIDFixed()
        {
            var resByID = await GetDataFlyersByIDAsync<Flyer>("1");
            Assert.IsTrue(resByID?.DataResult != null);
        }


        [TestMethod()]
        public async Task FlyersByDates()
        {
            var res = await GetDataFlyersAsync<Flyer>();

            if (res?.DataResult != null)
            {
                var minStartDate = res.DataResult.Data.Min(f => (DateTime?)f.StartAt);
                var maxFinishDate = res.DataResult.Data.Max(f => (DateTime?)f.FinishAt);

                var resByID = await GetDataFlyersByDateAsync<Flyer>(minStartDate, maxFinishDate);
                Assert.IsTrue(resByID?.DataResult != null);
            }

            Assert.IsTrue(res?.DataResult != null);
        }

        #endregion
    }
}