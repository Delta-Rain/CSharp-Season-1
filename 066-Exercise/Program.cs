namespace _066_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 字符读取
            ////用户输入一堆数字符号字符，提取里面的数字

            //char a = (char)Console.Read(); //读取一个数字
            //char b = (char)Console.Read();

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            ////输入一个a后，直接运行输出b，没有执行输入b这行代码
            ////因为输入a，相当于输入a以及换行符，b=换行符


            char c; //ASCII字符是'0' -- 55   '9'--
            int sum = 0;
            do
            {
                c = (char)Console.Read();
                if (c >= '0' && c <= '9')
                {
                    int num = c - '0';
                    sum += num;
                }
            } while (c != '@');
            Console.WriteLine(sum);




            #endregion
        }
    }
}