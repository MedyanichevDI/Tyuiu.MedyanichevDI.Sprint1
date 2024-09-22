using Tyuiu.MedyanichevDI.Sprint1.Task3.V14.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.MedyanichevDI.Sprint1.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: oрганизация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая позволяет определить число,                  *");
            Console.WriteLine("*полученное выписыванием в обратном порядке цифр                          *");
            Console.WriteLine("*заданного трехзначного числа.                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double number;
            
            Console.WriteLine("Введите значение X:");
            number = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.ReverseNumber(number));
            Console.ReadKey();
        }
    }
}
