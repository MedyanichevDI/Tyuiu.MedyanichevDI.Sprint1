using Tyuiu.MedyanichevDI.Sprint1.Task4.V20.Lib;

namespace Tyuiu.MedyanichevDI.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(5, 2);
            Assert.AreEqual(2, res);
        }
    }
}