using Tyuiu.FendelNS.Sprint3.Task2.V4.Lib;
namespace Tyuiu.FendelNS.Sprint3.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 9;
            Console.Title = "Спринт #2 | Выполнил: Фендель  Н.С. | СМАРТБ-24-1";       
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Фендель Николай Сергеевич | СМАРТБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет           *");
            Console.WriteLine("* произведение ряда по формуле                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Начало цикла: {startValue}");
            Console.WriteLine($" Конец цикла: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Произведение ряда: {ds.GetMultiplySeries(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}