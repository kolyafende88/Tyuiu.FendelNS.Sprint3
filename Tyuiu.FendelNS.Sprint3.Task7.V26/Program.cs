using Tyuiu.FendelNS.Sprint3.Task7.V26.Lib;
namespace Tyuiu.FendelNS.Sprint3.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Фендель Н. С. | СМАРТБ-24-1";     
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление итоговых решений по спринту к проекту.                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Фендель Николай Сергеевич | СМАРТБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите start: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите stop: ");
            int stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double[] res = ds.GetMassFunction(start, stop);
            for (int h = 0; h < res.Length; h++)
            {
                Console.WriteLine(res[h]);
            }
            Console.ReadKey();
        }
    }
}