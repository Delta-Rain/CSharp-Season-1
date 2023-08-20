namespace _007_数学运算
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45 / 10;
            double b = (double)45 / 10;
            double c = 45 / 10.0;   //其中一个数字是小数即可
            int d = 45 % 10;    //取模/求余
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("算法：得到一个二位数的十位和个位，例26");
            int num = 26;
            int onesPlace = num % 10; //取模，得到个位
            int tensPlace = num / 10; //得到十位
            Console.WriteLine("个位是{0}，十位是{1}", onesPlace, tensPlace);
        }
    }
}