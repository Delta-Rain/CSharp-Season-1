namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            //生成随机数
            int i = r.Next(); //生成一个非负数随机数
            Console.WriteLine(i);

            int i2 = r.Next(100); //0-99，左闭右开
            Console.WriteLine(i2);

            i = r.Next(4, 100); //4-99


        }
    }
}