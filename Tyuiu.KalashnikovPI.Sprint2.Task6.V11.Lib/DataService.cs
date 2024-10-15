using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KalashnikovPI.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int nextDay, nextMonth, nextYear;


            switch (m)
            {
                case 1: //kan
                case 3: //mar
                case 5: //may
                case 7: //jul
                case 8: //aug
                case 10: //oct
                case 12: //dec
                    if (n < daysInMonth[m - 1])
                    {
                        nextDay = n + 1;
                        nextMonth = m;
                        nextYear = g;
                    }
                    else
                    {
                        nextDay = 1;
                        nextMonth = m + 1;
                        nextYear = g;
                    }
                    break;

                case 2: //feb
                    if (n < daysInMonth[m - 1])
                    {
                        nextDay = n + 1;
                        nextMonth = m;
                        nextYear = g;
                    }
                    else
                    {
                        nextDay = 1;
                        nextMonth = m + 1;
                        nextYear = g;
                    }
                    break;

                case 4: //apr
                case 6: //jun
                case 9: //sep
                case 11: //nov
                    if (n < daysInMonth[m - 1])
                    {
                        nextDay = n + 1;
                        nextMonth = m;
                        nextYear = g;
                    }
                    else
                    {
                        nextDay = 1;
                        nextMonth = m + 1;
                        nextYear = g;
                    }
                    break;

                default:
                    throw new ArgumentException("Неправильный номер месяца!", nameof(m));
            }
            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear = g + 1;
            }

            return (nextDay, nextMonth, nextYear).ToString();
        }
    }
}
