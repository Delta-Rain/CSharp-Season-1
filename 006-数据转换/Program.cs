namespace _006_数据转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 方法一：括号强转
            int i = 1;
            short k = 2;
            k = (short)i;

            int n = 49;
            char b = (char)n;
            Console.WriteLine(b);

            char m = 'a';//char塞进int，直接隐式转换
            int x = m;
            Console.WriteLine(x);

            #endregion

            #region 方法二：Parse法
            //专门用于把字符串转成对应类型
            //必须能够转换成对应类型，否则报错
            string str = "123";
            int i2 = int.Parse(str);
            //以下为报错示例
            //string str2 = "123.45";
            //int i3 = int.Parse(str2);

            #endregion

            #region 方法三：Convert法



            #endregion

            #region 方法四：其它类型转string
            //变量.ToString();
            int a4 = 1;
            string str4 = a4.ToString();

            bool b4 = true;
            string bool4 = b4.ToString();

            string str5 = 1.ToString();
            str5 = 2.1.ToString();
            str5 = 'A'.ToString();
            str5 = 1.123f.ToString();

            //字符串拼接时自动调用ToString，如
            string str6 = "123afds" + true + 1 + 1.23;
            Console.WriteLine(str6);

            #endregion
        }
    }
}