using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KalashnikovPI.Sprint2.Task1V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c < d); //true
            res[1] = (a < b) & (c > d); //false
            res[2] = (a > b) || (c > d); //false
            res[3] = (a < b) && (c > d); //false
            res[4] = !(res[1]); //true
            res[5] = (a < b) ^ (c < d); //false

            return res;
        }
    }
}
