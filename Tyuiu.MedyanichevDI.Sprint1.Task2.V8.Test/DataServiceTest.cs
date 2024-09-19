using Tyuiu.MedyanichevDI.Sprint1.Task2.V8.Lib;

namespace Tyuiu.MedyanichevDI.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculatePerimetrVoid()
        {
            
            
            DataService ds = new DataService();
            var res = ds.CalculatePerimetr(2, 2);
            Assert.AreEqual(8, res);
        }
    }
}