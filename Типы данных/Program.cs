namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            string form = "{0}\t\t{1}\t\t{2,2}\t{3,30}\t{4}";
            string form1 = "{0}\t\t{1} {2,12}\t{3,30}\t{4}";
            Console.WriteLine(string.Format(form1,"Тип", "Название", "Размер", "Минимальное зн.", "Максимальное зн."));
            Console.WriteLine(string.Format("====================================================================================================="));
            Console.WriteLine(string.Format(form, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(form, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(form, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(form, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(form, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(form, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(form, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(form, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format(form, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(string.Format(form, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(string.Format(form, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format(form, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));
            Console.WriteLine(string.Format(form, "string", typeof(string).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine("\n");
            Console.WriteLine(string.Format(form, "object", typeof(object).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine(string.Format(form, "dynamic", "N/A", "N/A", "N/A", "N/A"));

            Console.ReadLine();
        }
    }
}