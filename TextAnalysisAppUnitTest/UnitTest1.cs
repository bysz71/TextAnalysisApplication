using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TextAnalysisAppControl;

namespace TextAnalysisAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new TextAnalysisAppControl.Class1();
            Assert.AreEqual(2, obj.add(1, 1));
        }
    }
}
