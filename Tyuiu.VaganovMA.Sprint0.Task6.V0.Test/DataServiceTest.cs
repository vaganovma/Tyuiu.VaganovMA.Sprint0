using Tyuiu.VaganovMA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.VaganovMA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionArrayValid()
        {
            var numbers = new int [] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckedSubtraktionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtraktionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckedMultiplicatioArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }

        
    }
}