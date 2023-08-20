using System.Threading.Channels;

namespace _090_排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一组数据，从小到大排序
            //（Array.Sort方法和冒泡排序）

            //获取输入的一组数据，并改为int数组
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                int num = int.Parse(strArray[i]);
                intArray[i] = num;
            }

            //Array.Sort方法，自动排序
            Array.Sort(intArray);
            //foreach遍历输出
            foreach (int temp in intArray)
            {
                Console.Write(temp + " ");
            }
    }
}