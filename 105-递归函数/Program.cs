namespace _105_递归函数
{
    internal class Program
    {
        static void Test()
        {
            Console.WriteLine("Test");
            Test();
            Console.WriteLine("Test2");
            //类似死循环，每次递归调用都会创建一个栈，死循环会导致栈空间溢出
        }
        static int F(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }
            int result = F(n - 1) + F(n - 2);
            return result;
        }
        static void Main(string[] args)
        {
            //fn = fn-1 + fn-2, f0 = 2, f1 = 3, 求f40
            //相当于fn1 + fn2
            #region 循环
            int n1 = 3; //f1
            int n2 = 2; //f0
            int n = 0;
            for (int i = 2; i < 41; i++) //i从2遍历到40
            {
                n = n1 + n2;
                n2 = n1;
                n1 = n;
            }
            Console.WriteLine(n);

            Console.WriteLine(F(40));
            #endregion
        }
    }
}