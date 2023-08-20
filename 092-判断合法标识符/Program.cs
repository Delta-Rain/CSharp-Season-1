namespace _092_判断合法标识符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //判断一个字符串是否是C#的合法标识符
            //字符串中的每个字符是否是数字、大小写字母、下划线
            //不能以数字开头

            //可以把字符串当做数组来访问
            //str.length获得长度，str[i]访问其中某个字符

            string str = Console.ReadLine();
            //判断是否是数字、字母、下划线
            bool isRight = true;
            for (int i = 0; i < str.Length; i++)
            {
                //不是数字&&不是字母&&不是下划线
                //不是数字 str[i]<'0' || str[i]>'9'
                if ((str[i] < '0' || str[i] > '9') && (str[i] < 'a' || str[i] > 'z') && (str[i] < 'A' || str[i] > 'Z') && (str[i] != '_'))
                {
                    isRight = false;
                    //有一个不合法就跳出
                    break;
                }
            }

            //第一个字符不能为数字
            if (str[0] > '0' || str[0] < '9')
            {
                isRight = false;
            }
        }
    }
}