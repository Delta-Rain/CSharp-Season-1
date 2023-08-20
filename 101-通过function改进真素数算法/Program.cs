namespace _101_通过function改进真素数算法
{
    internal class Program
    {
        static bool IsSu(int num)
        {
            bool isSu = true;
            for (int j = 2; j < num; j++)
            //遍历2~i-1，判断是否能整除，能则不是素数
            {
                if (num % j == 0) //能被整除，说明不是素数
                {
                    isSu = false;
                    break;
                }
            }
            return isSu;
        }
        static void Main(string[] args)
        {
            //找出正整数m和n之间的真素数，例如11、13
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int number = int.Parse(strArray[i]);
                intArray[i] = number;
            }

            int m = intArray[0];
            int n = intArray[1];

            //遍历m到n之间的每个数
            for (int i = m; i < n + 1; i++)
            {
                //判断j是否是素数
                //是则取得反序，再判断反序是否是素数
                bool isSu = IsSu(i);

                if (isSu) //是素数
                {
                    //取得反序
                    int num = 0;
                    int temp = i;
                    while (temp % 10 != 0)
                    {
                        num = num * 10 + temp % 10;
                        temp = temp / 10;
                    }
                    //判断反序是否是素数
                    bool isSuReverse = IsSu(num);

                    //是真素数，输出
                    if (isSuReverse == true)
                    {
                        Console.Write(i + " ");
                    }
                }


            }
        }
    }
}