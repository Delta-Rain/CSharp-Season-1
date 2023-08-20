namespace _024_三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3个空位 2个符号
            //空位? 空位: 空位;
            //bool类型? bool类型为真 返回内容: bool类型为假 返回内容;
            //必须有返回值，返回值类型必须一致

            string str = true ? "条件为真" : "条件为假";
            Console.WriteLine(str); //输出"条件为真"
            //通过第一个空位bool判断返回哪个值
            //可以返回任意类型，只是用bool来判断返回哪个

            int a = 1;
            double res = a > 0 ? 1 : 2.1;
            Console.WriteLine(a); //bool为真，输出冒号左边的1



        }
    }
}