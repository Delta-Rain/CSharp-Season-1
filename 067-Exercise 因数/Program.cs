namespace _067_Exercise_因数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输出一个数的因数
            //%=0就是因数
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //输出乘法口诀表
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", j, i, i * j);
                }
                Console.WriteLine();
            }




        }
    }
}