using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DBConnectorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string>[] result;
            DBConnector.DBConnector db = new DBConnector.DBConnector();
            result = db.Select();
            Assert.IsTrue(result.Length > 0);
        }
    }
}
