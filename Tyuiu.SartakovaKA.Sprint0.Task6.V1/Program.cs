using Tyuiu.SartakovaKA.Sprint0.Task6.V1.Lib;
namespace Tyuiu.SartakovaKA.Sprint0.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynumbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива " + DataService.AdditionArray(arraynumbers));
            Console.WriteLine("Разность элементов массива " + DataService.SubtractionArray(arraynumbers));
            Console.WriteLine("Произведение элементов массива " + DataService.MultiplicationArray(arraynumbers));
            Console.ReadKey();
        }

    }
}    
