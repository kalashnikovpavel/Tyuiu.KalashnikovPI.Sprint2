using Tyuiu.KalashnikovPI.Sprint2.Task4.V7.Lib;
namespace Tyuiu.KalashnikovPI.Sprint2.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCOndition1()
        {
            DataService ds = new DataService();
            double x = 15-10;
            double y = 2+2;
            double res = ds.Calculate(x, y);
            double wait = 141.25;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCOndition2()
        {
            DataService ds = new DataService();
            double x = 15-10;
            double y = 5+2;
            double res = ds.Calculate(x, y);
            double wait = 141.082;
            Assert.AreEqual(wait, res);
        }
    }
}