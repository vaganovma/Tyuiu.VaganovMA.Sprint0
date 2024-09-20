using Tyuiu.VaganovMA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.VaganovMA.Sprint0.Task3.V0.Testt
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(143, DataService.Sum(79, 64));
        }
    }
}