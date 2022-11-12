namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            double[] dobArray = { 1.1, 2.2, 3.3, 4.4 };
            string[] strArray = { "am", "it", "ku", "ma" };
            Program.ToPrint(intArray);
            Program.ToPrint(dobArray);
            Program.ToPrint(strArray);

            

 
        }
        public static void ToPrint(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("============================");
            
        }
        public static void ToPrint(double[] arr)
        {
            foreach (double element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("=============================");

        }
        public static void ToPrint(string[] arr)
        {
            foreach (string element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("==============================");
        }
    }
}