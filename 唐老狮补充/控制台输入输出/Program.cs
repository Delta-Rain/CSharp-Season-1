using System.Text;

namespace 控制台输入输出
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadKey().KeyChar;
            //获取用户输入的键

            Console.Clear();
            //清空

            //设置控制台大小
            //1. 先设置窗口大小，再设置缓冲区大小
            //2. 缓冲区大小不能大于

            //设置窗口大小
            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 50);

            //设置光标位置
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("132424532474575473652");

            //设置颜色相关
            //文字颜色
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1342");
            //背景颜色
            Console.BackgroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("1342");

            //光标显隐
            Console.CursorVisible = true;

            //关闭控制台
            Environment.Exit(0);
        }
    }
}