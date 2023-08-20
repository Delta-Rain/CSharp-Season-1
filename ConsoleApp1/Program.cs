namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入整数num，输出顺序相反的数，例如1234,4321
            //1234，取余数4放进temp，3进temp，2进temp，1进temp
            //rev初始为temp，rev=temp*10+rev
            while (true) 
            { 
                int n = int.Parse(Console.ReadLine());
                int orignial = n;
                int rev = 0;
                while (n > 0)
                {
                    int temp = n % 10;
                    rev = temp + rev * 10;
                    n /= 10;
                }
                if (orignial == rev)
                {
                    Console.WriteLine("yes.");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }


        }
    }
}