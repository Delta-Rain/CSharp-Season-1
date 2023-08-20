namespace _104_方法的重载
{
    internal class Program
    {
        static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static double MaxValue(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(new double[] { 1.1, 123, 34, 234, 325.1 }));
            Console.WriteLine(MaxValue(new int[] { 1, 123, 34, 234, 325 }));

        }
    }
}