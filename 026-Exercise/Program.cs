namespace _026_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入整数a，正整数n，计算a的n次方。
            //int a = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 0; i < n; i++)
            //{
            //    res *= a;
            //}
            //Console.WriteLine(res);

            //输入整数n，输出n的阶乘
            ////5=1*2*3*4*5
            //int n = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 1; i <=n ; i++)
            //{
            //    res *= i;
            //}
            //Console.WriteLine(res);

            //求q0次方+q1次方+...+qn次方
            //int q = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //int temp = 1;
            //int sum = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    temp *= q;
            //    sum += temp;
            //}
            //Console.WriteLine(sum);

            //int k = int.Parse(Console.ReadLine());
            //int n = 1;
            //double sum = 0;
            //while (sum <= k)
            //{
            //    sum += (1.0 / n);
            //    n++;
            //}
            //Console.WriteLine(n - 1);

            //现有X亿人口，每年0.1%增长，n年后有多少人？
            //x * 1.1 * 1.1 * 1.1 * 1.1 * 1.1 ...
            //double x = double.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //double res = x;
            //for (int i = 0; i < n; i++)
            //{
            //    res *= 1.001;
            //}
            //Console.WriteLine(res);


            //复合利率为r（0-20整数），m钱，投资y年（0-400），输出整数部分
            //m = m*(1+r)*y
            //int r = int.Parse(Console.ReadLine());
            //double m = double.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //for (int i = 0; i < y; i++)
            //{
            //    m = m * (1 + r / 100.0);
            //}
            //Console.WriteLine(m);

            //水仙花数 三位数100 <= n <= 999, 153= 1三次方+5三次方+3三次方
            //从100，个位开始遍历，101时，13+03+13==sum? =print, !=continue

            for (int huns=1; huns < 10; huns++)
            {
                for (int tens = 0; tens < 10; tens++)
                {
                    for (int ones = 0; ones < 10; ones++)
                    {
                        int sum = ones + tens * 10 + huns * 100;
                        int temp = huns * huns * huns + tens * tens * tens + ones * ones * ones;
                        if (sum == temp)
                        {
                            Console.WriteLine(sum);
                        }
                    }
                }

            }





        }
    }
}