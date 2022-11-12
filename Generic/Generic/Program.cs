using System.Drawing;

namespace Generic
{

    public class InputArray<T>
    {
        private T[] inputArr;
        public InputArray(T[] inputArr)
        {
            this.inputArr = inputArr;
        }
        public void ToPrint()
        {
            foreach (var element in inputArr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("===================");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] dobArray = { 1.1, 2.2, 3.3, 4.4 };
            string[] strArray = { "am", "it", "ku", "ma" };

            new InputArray<int>(intArray).ToPrint();
            new InputArray<double>(dobArray).ToPrint();
            new InputArray<string>(strArray).ToPrint();
         }

    }
}