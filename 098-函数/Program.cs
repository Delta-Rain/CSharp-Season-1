namespace _098_函数
{
    internal class Program
    {
        static void VerifyUserName(string username) //形参 形式参数 只有调用这个方法时，这个形参才会被赋值
        //     返回值 方法名       (参数)
        //方法外无法取得方法内的变量值
        {
            Console.WriteLine("校验逻辑修改");
            Console.WriteLine("校验用户名"+username);
            //方法体
        }

        static int Add(int a, int b)
        {
            int result = a+ b;
            return result;
        }

        //主函数 入口函数 主方法 入口方法
        static void Main(string[] args)
        {
            VerifyUserName("siki"); //实参 实际参数
            //会把siki赋值给方法参数中的username

            Add(1, 2);


        }
    }
}