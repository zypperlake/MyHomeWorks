namespace Program
{
    public class HomeWorks
    {
        static void Main(string[] args)
        {
            //Задача такая: Нужно определить число на чётность и нечётность.

            Console.WriteLine("Введите число");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value % 2 == 0)
            {
                Console.WriteLine("Число чётное!");
            }
            else
            {
                Console.WriteLine("Число нечётное!");
            }
        }
    }
}