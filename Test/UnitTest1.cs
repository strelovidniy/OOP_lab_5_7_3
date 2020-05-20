using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("ii",new OOP_lab_5_7_3.Doctor().UkrainianI("??"));
        }
    }
}
