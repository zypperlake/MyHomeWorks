namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("====================");
            //Вывод по первому варианту
            for (int count = ints.Length - 1; count >= 0; count--)
            {
                Console.Write("{0} {1}", ints[count], "");
            }

            Console.WriteLine("\n====================");

            //Вывод по второму варианту
            for (int count = ints.Length; count > 0;)
            {
                --count;
                Console.Write("{0} {1}", ints[count], "");
            }
            Console.WriteLine("\n====================");
        }
    }
}