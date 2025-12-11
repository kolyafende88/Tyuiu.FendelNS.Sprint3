using Tyuiu.FendelNS.Sprint3.Task4.V19.Lib;
namespace Tyuiu.FendelNS.Sprint3.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Фендель Н.С. | СМАРТБ-24-1";            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Использование операторов continue и break в циклах               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Фендель Николай Сергеевич| СМАРТБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5,                        *");
            Console.WriteLine("* вычислить значение функции y=x/(cos(x) + x)+0.5.                        *");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения перемножать.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = Convert.ToDouble(ds.Calculate(startValue, stopValue));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}