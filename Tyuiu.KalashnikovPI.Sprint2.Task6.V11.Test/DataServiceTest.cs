using Tyuiu.KalashnikovPI.Sprint2.Task6.V11.Lib;
namespace Tyuiu.KalashnikovPI.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int g = 2022;
            int m = 1;
            int n = 15;

            string result = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual("(16, 1, 2022)", result);
        }
        [TestMethod]
        public void TestJanuaryEndOfMonth()
        {
            DataService ds = new DataService();

            int g = 2022;
            int m = 1;
            int n = 31;

            string result = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual("(1, 2, 2022)", result);
        }
        [TestMethod]
        public void TestDecemberEndOfYear()
        {
            DataService ds = new DataService();
            int g = 2022;
            int m = 12;
            int n = 31;

            string result = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual("(1, 1, 2023)", result);
        }
        [TestMethod]
        public void TestInvalidMonth()
        {
            DataService ds = new DataService();
            int g = 2022;
            int m = 13;
            int n = 15;
            Assert.ThrowsException<ArgumentException>(() => ds.FindDateOfNextDay(g, m, n));
        }
    }
}