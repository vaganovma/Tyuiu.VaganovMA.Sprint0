using Tyuiu.VaganovMA.Sprint0.Task5.V0.Lib;

namespace Tyuiu.VaganovMA.Sprint0.Task5.V0;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("A + B = " + DataService.Addition(79, 64));

        Console.WriteLine("A - B = " + DataService.Subtraktion(484, 341));

        Console.WriteLine("A * B = " + DataService.Multiplication(13, 11));

        Console.WriteLine("A / B = " + DataService.Division(2574, 18));

        Console.ReadKey();


    }
}