namespace _008_自增自减运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            a++; //让a自增1
            ++a; //+号放在前后均可
            Console.WriteLine(a);

            int a1 = 8;
            int b = a1++; //先赋值再自增，得8
            int c = ++a1; //先自增再赋值，得10，谁在前先算谁
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}