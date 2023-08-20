namespace _103_计算最大值和计算因子
{
    internal class Program
    {
        //定义一个function，取得数组中的最大值
        #region 方法一：冒泡一轮
        static int Max(params int[] intArray)
        {
            for (int j = 0; j < intArray.Length - 1; j++)
                //只进行一轮冒泡即可得到最大值
                {
                    if (intArray[j] >= intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            return intArray[intArray.Length - 1];
        }
        #endregion

        #region 方法二：int max直接赋值
        static int Max2(params int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        #endregion

        //定义一个function，取得一个数字的所有因子，把所有因子返回
        static int[] GetDivisor(int num)
            //形参应是一个int
        {
            int count = 0;
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            int[] array = new int[count];
            int index = 0;
            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {

            //取得数组
            //string str = Console.ReadLine();
            //string[] strArray = str.Split(" ");
            //int[] intArray = new int[strArray.Length];
            //for (int i = 0; i < strArray.Length; i++)
            //{
            //    int num = int.Parse(strArray[i]);
            //    intArray[i] = num;
            //}
            //以上一整段相当于 方法形参直接加 params


            //Console.WriteLine(Max());
            //Console.WriteLine(Max2());
            int a = int.Parse(Console.ReadLine());
            int[] array = GetDivisor(a);
            foreach (int temp in array)
            {
                Console.Write(temp + " ");
            }





        }
    }
}