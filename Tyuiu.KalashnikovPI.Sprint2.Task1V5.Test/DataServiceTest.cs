using Tyuiu.KalashnikovPI.Sprint2.Task1V5.Lib;
namespace Tyuiu.KalashnikovPI.Sprint2.Task1V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOpetations()
        {
            DataService ds = new DataService();
            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}