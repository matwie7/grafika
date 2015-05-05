using MGrafika.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.MTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = FileOpening.GetFilePath();
            Assert.IsNotNull(res);
        }
    }
}
