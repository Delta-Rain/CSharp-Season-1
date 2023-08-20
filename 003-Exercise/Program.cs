namespace _003_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = (double)(a + b) / 2;
            Console.WriteLine(c);
        }
    }
}