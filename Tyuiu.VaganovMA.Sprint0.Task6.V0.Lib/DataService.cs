namespace Tyuiu.VaganovMA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {    //цикл с параметром
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }
        //цикл с предусловием
        public static int SubtraktionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        //цикл с постусловием
        public static int MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;

            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }




    }
}
