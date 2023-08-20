namespace _105_递归练习
{
    internal class Program
    {
        static int F(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * F(n - 1);
        }
        static void Main(string[] args)
        {
            //递归求10!

            #region 方法一：循环


            //循环
            int n = 10;
            int product = 1;
            while (n > 1)
            {
                product *= n;
                n--;
            }
            #endregion

            #region 方法二：递归
            // f(n) = n * f(n-1)
            // 10! = 10 * 9!
            // f(1) = 1
            Console.WriteLine(F(10));
            #endregion


        }
    }
}