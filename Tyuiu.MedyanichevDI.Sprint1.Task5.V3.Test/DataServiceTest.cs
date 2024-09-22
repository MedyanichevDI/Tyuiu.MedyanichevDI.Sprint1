using Tyuiu.MedyanichevDI.Sprint1.Task5.V3.Lib;
namespace Tyuiu.MedyanichevDI.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(130985);
            Assert.AreEqual(9, res);
        }
    }
}           