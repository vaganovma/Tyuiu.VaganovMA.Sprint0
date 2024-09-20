using Tyuiu.VaganovMA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VaganovMA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(143, DataService.Addition(79, 64));
        }

        [TestMethod]
        public void CheckedSubtraktionValid()
        {
            Assert.AreEqual(143, DataService.Subtraktion(484, 341));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(143, DataService.Multiplication(13, 11));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(143, DataService.Division(2574, 18));
        }
    }
}