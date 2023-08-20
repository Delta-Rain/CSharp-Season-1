namespace _093_判断是否是回文字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //回文字符串，字符个数分奇数偶数
            //例如 8个字符，只需要遍历前8/2=4个，即索引0-3
            //7个字符，遍历前7/2=3个，索引4不需要遍历
            //7个字符，索引0 - 索引6，索引1 - 索引5，索引i - 索引length-1-i
            bool isHui = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                //i - length-1-i是否相等，如不相等则不是回文
                if (str[i] != str[str.Length - 1 - i])
                {
                    isHui = false;
                    break;
                }
            }
            if (isHui)
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是");
            }




        }
    }
}