namespace _018_循环语句_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////输出1-10
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i++);
            //}
            ////满足条件时，循环运行；不满足时，跳出循环，执行后面代码
            ////while (true) 恒true，死循环

            //int HP = 100;
            //while (HP > 0)
            //{
            //    HP -= 12;

            //    if (HP <= 0)
            //    {
            //        Console.WriteLine("0点HP");
            //        Console.WriteLine("YOU DIED");
            //    }
            //    else
            //    {
            //        Console.WriteLine(HP + "点HP");
            //    }
            //}


            ////输入n，输出1+2+...+n
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= n)
            //{
            //    sum = sum + i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            //输出1-100之间的偶数
            //int a = 1;
            //while (a <= 100)
            //{
            //    if (a%2 == 0) Console.WriteLine(a);
            //    a++;
            //}

            //输入n1和n2，输出n1-n2（含）间所有偶数
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                int temp = n1; n1 = n2; n2 = temp;
            }
            int i = n1;
            while (i < n2 + 1)
            {
                if (i % 2 == 0) Console.WriteLine(i);
                i++;
            }


        }
    }
}