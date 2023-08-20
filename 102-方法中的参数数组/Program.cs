namespace _102_方法中的参数数组
{
    internal class Program
    {
        static int Add1(int a, int b)
            //function只能计算两个数字的和
        {
            return a + b;
        }

        static int Add2(int[] array)
            //如要计算n个数字的和，参数可设置为int array
        {
            int sum = 0;
            foreach (int x in array)
            {
                sum += x;
            }
            return sum;
        }

        static int Add3(params int[] array)
        //可以传递任意个数的参数，自动构建数组
        {
            int sum = 0;
            foreach (int x in array)
            {
                sum += x;
            }
            return sum;
        }

        static int Add4(string name, params int[] array)
        //可以传递其他类型参数，如string，但params int[]必须放在最后
        {
            int sum = 0;
            foreach (int x in array)
            {
                sum += x;
            }
            return sum;
        }

        static void Main(string[] args)
        {

            int sum = Add2(new int[] { 2, 4, 6 });
            Console.WriteLine(sum);

            int[] array2 = { 6, 36, 8 };
            int sum2 = Add2(array2);
            Console.WriteLine(sum2);

            //Add2({1,4,5});
            //不行，必须先创建数组，先声明再赋值

            int sum3 = Add3(1, 432, 6);
            Console.WriteLine(sum3);

            Console.WriteLine(Add3(1, 5, 3));

        }
    }
}