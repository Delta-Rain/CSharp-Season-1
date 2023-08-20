namespace _108_阶乘练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1*1+2*2+...+k*k < 2000，求k最大值
            //可以找出 >= 2000 时k的值，k-1即是所求

            int k = 1;
            int result = 0;
            while (true)
            {
                result += k * k;
                if (result >= 2000) break;
                k++;
            }
            Console.WriteLine(k - 1);

            int i = 1;
            while (true)
            {
                if (F(i) >= 2000) break;
                i++;
            }
            Console.WriteLine(i - 1);



        }



        //f(n) = 1²+2²+...+n²
        //f(n) = f(n-1) + n²
        //f(1) = 1
        static int F(int n)
        {
            if (n == 1) return 1;
            return F(n - 1) + n * n;
        }
    }
}