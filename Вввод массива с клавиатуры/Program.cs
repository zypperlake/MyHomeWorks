namespace Вввод_массива_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.Write("Введите диапазон массива: ");
            int input_count = 0;
            try { input_count = int.Parse(Console.ReadLine()); }
            catch { Console.WriteLine("Введено неккоректное число!"); }

            int[] Massive = new int[input_count];

            Console.WriteLine("=========================");

            for(int i = 0; i < Massive.Length; )
            {
                Console.WriteLine($"Введите значение элемента с индексом {i}:");
                try { Massive[i] = int.Parse(Console.ReadLine()); i++; }
                catch {
                    Console.WriteLine("=========================");
                    Console.WriteLine("Не удалось добавить элемент! \nПопробуйте ещё раз!");
                    Console.WriteLine("=========================");
                }
            }

            Console.WriteLine("=========================");
            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < Massive.Length; i++)
            {
                Console.WriteLine(Massive[i]);
            }
        }
    }
}