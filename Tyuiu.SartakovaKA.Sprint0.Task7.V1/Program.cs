using System.Diagnostics.CodeAnalysis;
using Tyuiu.SartakovaKA.Sprint0.Task7.V1.Lib;
namespace Tyuiu.SartakovaKA.Sprint0.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Сартакова К.А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема:Создания итогового решения по спринту                              *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Сартакова Ксения Андреевна | ИСТНб-26-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одинаковых массивов по длине.                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arraynums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива  №1");
            for (int i = 0; i < arraynums1.Length;i++)
            {
                Console.WriteLine(arraynums1[i] + ", ");
            }
            Console.WriteLine();
            int[] arraynums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива  №2");
            for (int i = 0; i < arraynums2.Length; i++)
            {
                Console.WriteLine(arraynums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (arraynums1.Length == arraynums2.Length)
            {
                int[] resultarray = DataService.AdditionArrays(arraynums1, arraynums2);
                Console.WriteLine("Сумма элементов массива равна: ");
                for (int i = 0; i < resultarray.Length;i++)
                {
                    Console.WriteLine(resultarray[i] + ", ");
                }

            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();

        }
    }
}
//Task7