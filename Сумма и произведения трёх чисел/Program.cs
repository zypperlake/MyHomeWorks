namespace Program
{
    public class HomeWorks
    {
        static void Main(string[] args)
        {
            //Задание такое: Нужно считать с пользователья три числа, потом сложить их, и произвести.
            //Так вот, Я сделал значения зашитый в коде, и не понимая термин Произведения, сделал вычетания.
            //Но потом исправил ситуацию, скопировал немного кода у автора курса :)
            
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Заданы: a = {a}, b = {b}, c = {c}");
            Console.WriteLine("Сумма => " + (a + b + c));
            Console.WriteLine("Произведения => " + (a * b * c));
        }
    }
}