using Tyuiu.KalashnikovPI.Sprint2.Task6.V11.Lib;
namespace Tyuiu.KalashnikovPI.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string res;

            Console.Title = "Спринт #2 | Выполнил: Калашников П. И. | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 2                                                                *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Калашников Павел Ильич | СМАРТб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год)* ");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g n и m определить* ");
            Console.WriteLine("* дату следующего дня.                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫНЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день:");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((g < 1) || (m < 1) || (m > 12) || (n < 1) || (n > 31))
            {
                res = "Выход за предел значений";
            }
            else
            {
                res = "Следующая дата: " + ds.FindDateOfNextDay(g, m, n);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
