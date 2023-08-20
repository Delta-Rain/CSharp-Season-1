namespace _074_随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //随机数的生成
            Random rd = new Random();
            //伪随机
            //Console.WriteLine(rd.Next(1, 10)); //左闭右开

            int num = rd.Next(1, 101);
        }
    }
}