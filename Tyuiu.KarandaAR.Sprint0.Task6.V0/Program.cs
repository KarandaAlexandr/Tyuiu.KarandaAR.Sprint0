using Tyuiu.KarandaAR.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KarandaAR.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Сумма элементов массива = " + DataService.SubstrationArray(arraynums));
            Console.WriteLine("Сумма элементов массива = " + DataService.MultiplicationArray(arraynums));
            
            Console.ReadKey();
        }
    }
}
