namespace _107_阶乘练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //求1+2!+3!+4!+5!+...+!10

            //外层循环
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {

                int product = 1;
                for (int j = 1; j <= i; j++)
                {
                    product *= j;
                }
                sum += product;
            }
            Console.WriteLine(sum);

            //f(n) = 1 + 2! + 3! + 4! + 5! + ...+!n
            //f(n) = f(n-1) + n!
            //F1(n) = n!
            //F2(n) = F2(n-1) + n!
            Console.WriteLine(F2(10));

        }
        static int F1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int result = n * F1(n - 1);
            return result;
        }
        static int F2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return F2(n - 1) + F1(n);
        }
    }
}