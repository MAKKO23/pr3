namespace ConsoleApp2Maxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            char zn;
            Console.WriteLine("Введите первую переменную: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите занк");
            zn = Convert.ToChar(Console.ReadLine());
            if (zn == '+')
            {
                c = a + b;
                Console.WriteLine("Ответ: " + c);
            }
            else if (zn == '-')
            {
                c = a - b;
                Console.WriteLine("Ответ: " + c);
            }
            else if (zn == '/')
            {
                c = a / b;
                Console.WriteLine("Ответ: " + c);
            }
            else if (zn == '*')
            {
                c = a * b;
                Console.WriteLine("Ответ: " + c);
            }
        }
    }
}