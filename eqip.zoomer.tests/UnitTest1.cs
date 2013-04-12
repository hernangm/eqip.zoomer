using System;
using eqip.core.xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eqip.zoomer.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var config = new ZoomerConfig();
            config.markers.Add(new Marker());
            var xml = XmlHelper.Serialize(config);
        }
    }
}
