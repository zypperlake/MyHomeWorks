namespace Program
{
    public class HomeWorks
    {
        static void Main(string[] args)
        {
            //Выводим триугольник в правильном порядке
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Выводим триугольник в обратном порядке
            for (int i = 10; i != 0; --i)
            {
                for (int j = 0; j != i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            //Выводим триугольник в правильном порядке, чтобы он выходил перевернуто (заполняем пустые места пробелом)
            for (int i = 10; i >= 0; --i)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 10; k > i; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Выводим триугольник в обратном порядке, чтобы он выходил перевернуто (также заполняем пустые места пробелом)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 10; k > i; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}