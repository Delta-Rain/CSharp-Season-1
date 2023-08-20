namespace _010_逻辑运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年龄，我来判断是否是青年（18-60岁）。");
            int a = Convert.ToInt32(Console.ReadLine());
            bool ageTF = a >= 18 && a <= 60;
            Console.WriteLine(ageTF);

        }
    }
}