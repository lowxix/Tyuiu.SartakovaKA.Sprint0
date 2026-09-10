using Tyuiu.SartakovaKA.Sprint0.Task4.V1.Lib;
namespace Tyuiu.SartakovaKA.Sprint0.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(10, 5));
            Console.WriteLine(DataService.Division(9, 3));
            Console.WriteLine(DataService.Multiplication(10, 5));
            Console.ReadKey();
        }
    }

}
