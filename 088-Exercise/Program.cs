using System.Threading.Channels;

namespace _088_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 用户输入一堆数字，空格隔开，找出最小的一个与第一个数字交换
            //132 4 65 536 63 42 76
            string str= Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            //必须先声明，再赋值，再索引。不赋值无法索引
            //然后遍历字符数组里每一个，放入int数组
            for (int i = 0; i < strArray.Length; i++)
            {
                int num = int.Parse(strArray[i]);
                //把字符串里每个数字转换成对应整型，放入int数组
                intArray[i] = num;
            }

            int min = intArray[0];
            int minIndex = 0;
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                    //找出最小值
                    minIndex = i;
                    //找出最小值索引
                }
            }

            int temp = intArray[0];
            //第一个数字放入temp
            intArray[0] = intArray[minIndex];
            //min放入第一个数字
            intArray[minIndex] = temp;
            foreach (int t in intArray)
            {
                Console.Write(t + " ");
            }








            #endregion




        }
    }
}