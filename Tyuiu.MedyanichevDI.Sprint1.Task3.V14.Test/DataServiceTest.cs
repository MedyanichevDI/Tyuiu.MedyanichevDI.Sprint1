using Tyuiu.MedyanichevDI.Sprint1.Task3.V14.Lib;
namespace Tyuiu.MedyanichevDI.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            double res = ds.ReverseNumber(843.321);
            Assert.AreEqual(123.348, res);
        }
    }
}