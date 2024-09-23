using Tyuiu.MedyanichevDI.Sprint1.Task6.V12.Lib;

namespace Tyuiu.MedyanichevDI.Sprint1.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Медяничев Д.И. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Медяничев Денис Игоревич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу: пользователь вводит текст.                           *");
            Console.WriteLine("*Проверить, что последнее слово строки входит в нее еще раз.              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string k;

            Console.WriteLine("Введите значение предложение:");
            k =Convert.ToString(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ds.CheckLastWordRepetiton(k) == true)
            {
                Console.WriteLine("Слово повторяется");
            }
            else {
                Console.WriteLine("Слово не повторяется");
                    }
            
            Console.ReadKey();
        }
    }
}
