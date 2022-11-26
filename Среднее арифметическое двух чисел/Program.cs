namespace Program
{
    public class HomeWorks
    {
        static void Main(string[] args)
        {
            //Задание такое: Нужно вывести среднее арифметическое двух чисел, 
            //числа мы принимаем от пользователя. Что я не сделал до этого, это не предусмотрел
            //вариант ввода дробных чисел, что потом исправил :)

            double firstValue, secondValue;

            Console.Write("Введите первое число => ");
            firstValue = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Введите второе число => ");
            secondValue = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Результат операции: " + (firstValue + secondValue) / 2);
        }
    }
}