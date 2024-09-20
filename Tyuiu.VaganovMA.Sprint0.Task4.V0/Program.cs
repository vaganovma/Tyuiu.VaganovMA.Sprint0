using Tyuiu.VaganovMA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VaganovMA.Sprint0.Task4.V0;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DataService.Addition(79, 64));
       
        Console.WriteLine(DataService.Subtraktion(484, 341));
        
        Console.WriteLine(DataService.Multiplication(13, 11));
        
        Console.WriteLine(DataService.Division(2574, 18));

        Console.ReadKey();


    }
}