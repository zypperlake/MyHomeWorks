namespace Program
{
    public class HomeWorks
    {
        static void Main(string[] args)
        {
            bool debug = false;
            
            Console.WriteLine("Среднее арифметическое двух чисел");
            Console.WriteLine("=================================");

            Console.Write("Введите первое число => ");
            byte num1 = Convert.ToByte(Console.ReadLine());
            if (debug) { Console.WriteLine("\n" + Environment.StackTrace + "\n"); }

            Console.Write("Введите второе число => ");
            int num2 = Convert.ToByte(Console.ReadLine());
            if (debug) { Console.WriteLine("\n" + Environment.StackTrace + "\n"); }

            Console.WriteLine("=================================");
            Console.WriteLine($"Результат операции   => {(num1 + num2) / 2}");
            if (debug) { Console.WriteLine("\n" + Environment.StackTrace + "\n"); }

            Console.WriteLine("=================================");
            Console.WriteLine("\n" + "Дополнительная информация:");
            string format = "      {0,3}\t|    {1,4} ";
            Console.WriteLine("=================================");
            Console.WriteLine(string.Format(format, "Тип", "Значение"));
            Console.WriteLine("---------------------------------");
            Console.WriteLine(string.Format(format, num1.GetTypeCode(), num1));
            Console.WriteLine(string.Format(format, num2.GetTypeCode(), num2));
            Console.WriteLine("=================================");
            if (debug) { Console.WriteLine("\n" + Environment.StackTrace + "\n"); }
        }
    }
}