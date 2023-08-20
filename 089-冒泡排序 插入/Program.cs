namespace _089_冒泡排序_插入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //有一堆整数，从小到大排列，现插入一个数，要放进序列中保持从小到大
            //1 24 35 67 453
            //输入x 需要满足 索引i <= x <= i+1
            //原数组length  新数组length+1
            //x前的数不变，x后的数，索引向后移一位
            //x插入的位置即i，i+1的数都向后移一位

            //得到输入的一组有序数组
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int num = int.Parse(strArray[i]);
                intArray[i] = num;
            }

            //得到一个输入的数字
            int x = int.Parse(Console.ReadLine());
            //遍历在什么情况下 索引m <= x <= m+1
            int m = 0;
            bool find = false; //是否找到满足条件的索引位置，索引m <= x <= m+1
            for (int i = 0; i < intArray.Length - 1; i++) //不能遍历到最后一个索引，因为要满足x <= 索引m+1
            {
                if (x >= intArray[i] && x <= intArray[i + 1])
                {
                    m = i;
                    find = true; //找到了则find变为true
                    break;
                }
            }
            if (x < intArray[0])
            {
                m = -1;
                //如果x最小，插入最前面
            }

            if (find == false) //没有找到的话，就把m设置为最大索引
            {
                m = intArray.Length - 1;
            }

            //建立新数组，把x放进去
            int[] intArrayNew = new int[intArray.Length + 1];
            //索引0-m不动
            for (int i = 0; i < m; i++)
            {
                intArrayNew[i] = intArray[i];
            }
            intArrayNew[m + 1] = x; //x放到m+1的位置
            //m后的数，m+1 ~ length-1
            for (int i = m + 1;  i < intArrayNew.Length -1; i++)
            {
                intArrayNew[i + 1] = intArray[i];
            }

            //输出每个数
            foreach (int temp in intArrayNew)
            {
                Console.Write(temp+" ");
            }

        }
    }
}