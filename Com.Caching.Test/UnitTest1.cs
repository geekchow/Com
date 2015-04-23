using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Com.Caching.Expirations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Com.Caching.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cacheMngr = CacheFactory.GetCacheManager();
            cacheMngr.Add("phil","it's my name", CacheItemPriority.Low, null,new SlidingTime(new TimeSpan(0,0,0,50)));
            Assert.AreEqual(cacheMngr.GetData("phil"), "it's my name");
            Thread.Sleep(51*1000);
            Assert.AreEqual(cacheMngr.GetData("phil"), null);
        }
    }
}
