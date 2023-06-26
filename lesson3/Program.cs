namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("belgini kirit");
            char belgi=char.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            if (belgi == '*' )
            {
                Console.WriteLine(a + "*" + b + "=" + a * b);
            } 
            else if(belgi == '/') 
            {
                Console.WriteLine(a + "/" + b + "=" + a / b);
            }
            else if (belgi == '-')
            {
                Console.WriteLine($"{a} - {b} = {a-b}");
            }
            else if (belgi == '+')
            {
                Console.WriteLine(a + "+" + b + "=" + a + b);
            }
        }
    }
}