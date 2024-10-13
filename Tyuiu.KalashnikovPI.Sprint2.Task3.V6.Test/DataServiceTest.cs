using Tyuiu.KalashnikovPI.Sprint2.Task3.V6.Lib;
namespace Tyuiu.KalashnikovPI.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = -0.5;
            Assert.AreEqual(wait, res);
        }

        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(wait, res);
        }
    }
}