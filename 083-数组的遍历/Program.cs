using System.Security.Cryptography;

namespace _083_数组的遍历
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = new int[9]; //默认值0
            //char[] charArray = new char[20];
            //float[] floatArray = new float[5];
            //string[] stringArray = new string[8]; //默认值null
            //Console.WriteLine(intArray[3]);

            //数组的遍历 for
            int[] intArray2 = { 12, 1234, 543, 122, 65, 456 };
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.Write(intArray2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //数组的遍历 foreach 只能正序
            foreach (int temp in intArray2)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //倒序遍历
            for (int i = intArray2.Length; i >-1 ; i--)
            {
                Console.Write(intArray2[i] + " ");
            }

        }
    }
}