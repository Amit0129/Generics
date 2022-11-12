namespace Generic
{
    internal class Program
    {
        public static void ToPrint<T>(T [] arr)
        {
            foreach (T element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("============================");

        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] dobArray = { 1.1, 2.2, 3.3, 4.4 };
            string[] strArray = { "am", "it", "ku", "ma" };
            Program.ToPrint<int>(intArray);
            Program.ToPrint<double>(dobArray);
            Program.ToPrint<string>(strArray);
        }

    }
}