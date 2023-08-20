namespace _015_排序题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //任意输入三个数，从小到大排序输出
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int min = a;
            //if (b < min) min = b;
            //if (c < min) min = c;
            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;
            //int mid = a;
            //if (b < mid)
            //{
            //    if (c < b) mid = b;
            //    else if (c > b && c < a) mid = c;
            //}
            //else if (b > mid)
            //{
            //    if (c > b) mid = b;
            //    else if (c < b && c > a) mid = c;
            //}
            //Console.WriteLine("{0} {1} {2}", min, mid, max);


            //冒泡排序
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //} else if (b > c)
            //{
            //    int temp = b;
            //    b = c;
            //    c = temp;
            //}
            //if (a > b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //Console.WriteLine(a + " " + b + " " + c);

            //输入小数m和整数k，k为0或1
            //如k为0，输出m的整数部分   eg 4.65 0 4
            //如k为1，输出四舍五入保留一位小数的m  eg 4.65 1 7
            //double m = Convert.ToDouble(Console.ReadLine());
            //int k = Convert.ToInt32(Console.ReadLine());
            //if (k == 0)
            //{
            //    int temp = (int)m;  //double强塞进int，丢失小数部分
            //    Console.WriteLine(temp); //得到整数部分
            //}
            //else
            //{
            //    //eg. 3.2344 + 0.05，加0.05后去掉第一位小数后的部分即可。
            //    double temp = ((int)((m + 0.05) * 10)) / 10.0;
            //    Console.WriteLine(temp);
            //}

            //判断用户输入的是否是小写字母,a-z
            //char c = Convert.ToChar(Console.ReadLine());
            //if (c >= 'a' && c <= 'z') ;

            Console.WriteLine(3/2);

        }
    }
}