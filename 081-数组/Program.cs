namespace _081_数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 30;

            int age1 = 12;
            int age2 = 12;
            int age3 = 12;
            int age4 = 12;
            int age5 = 12;
            int age6 = 12;
            int age7 = 12;
            int age8 = 12;
            int age9 = 12;
            int age10 = 12;

            //声明int类型的数组
            //int[] ages = { 12, 123, 4325, 536, 23 }; //只能放对应类型的数据
            //double[] char[] string[]
            //可以先声明，再赋值
            //数组的数据有下标
            //从0开始排     0,  1  , 2   , 3  , 4 (索引)
            //数组名[索引]
            //Console.WriteLine(ages[2]); //4325

            int[] ages;
            //ages = new int[10]; //创建一个数组，且长度为10。默认值都是0
            ages = new int[] { age1, age2, age3, age4, age5, age6, age7 };
            ages = new int[3] { age1, age2, age3 };//[]内的长度必须和{}中数量一致


        }
    }
}