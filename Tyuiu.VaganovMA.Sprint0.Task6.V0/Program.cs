using Tyuiu.VaganovMA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.VaganovMA.Sprint0.Task6.V0;
class Program
{
    static void Main(string[] args)
    {
        int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Сумма эдементов массива = " + DataService.AdditionArray(numsArray));

        Console.WriteLine("Разность эдементов массива = " + DataService.SubtraktionArray(numsArray));

        Console.WriteLine("Произведение эдементов массива = " + DataService.MultiplicationArray(numsArray));
            
        Console.ReadKey();


    }
}