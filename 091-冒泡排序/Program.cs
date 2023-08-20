namespace _091_冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //获取一组数据并放入intArray
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                int num = int.Parse(strArray[i]);
                intArray[i] = num;
            }

            //获得一组n个数字，需要进行n-1轮排序。因为一轮遍历后，已经确定最大的数字，不需要再遍历到最后一位
            for (int j = 0; j < intArray.Length - 1; j++) //外层循环，进行length-1轮遍历
            {
                //内层循环，进行比较
                //定义一个bool，如果整轮中没有发生交换，后面就不用再遍历交换了
                //设置初始为false，一旦发生交换，就变为true

                bool isChange = false;
                for (int k = 0; k < intArray.Length - 1 - k; k++)
                //这里会浪费很多次循环，因为每次遍历后，最大值都已经挪到右侧。所以每次循环后，循环次数需-1
                //例如 k = 0， 循环length-1次
                //     k = 1， 循环length-1 -1次
                //     k = 2， 循环length-1 -2次
                // k < intArray.Length-1 优化为 k < intArray.Length - 1 - k
                {
                    //相邻位大小比较，交换
                    if (intArray[k] >= intArray[k + 1])
                    {
                        int temp = intArray[k];
                        intArray[k] = intArray[k + 1];
                        intArray[k + 1] = temp;
                        isChange = true;
                    }
                }
                //一次都没有发生的话，isChange = false，直接跳出循环
                if (isChange == false)
                {
                    break;
                }

            }

            //遍历输出
            foreach (int temp in intArray)
            {
                Console.Write(temp + " ");
            }
        }
    }
}