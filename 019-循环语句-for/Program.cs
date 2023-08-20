namespace _019_循环语句_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (初始化; 条件表达式; 增量表达式) {}
            //int i = 0;
            //for (; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(i);


            for (; ; )
            {
                try
                {
                    Console.WriteLine("请输入一个数字");
                    int inpu = int.Parse(Console.ReadLine());

                    int i = 2;
                    while (i < inpu)
                    {
                        if (inpu % i == 0)
                        {
                            break;
                        }
                        ++i;
                    }
                    if (i != inpu)
                    {
                        Console.WriteLine("不是质数");
                    }
                    if (i == inpu)
                    {
                        Console.WriteLine("是质数");
                    }
                }
                catch
                {
                    Console.WriteLine("请正确输入");
                }

            }

        }
    }
}