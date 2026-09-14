using Tyuiu.GusevaAS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GusevaAS.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Алиса"));
            Console.ReadKey();
        }
    }
}