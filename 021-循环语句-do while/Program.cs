namespace _021_循环语句_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
            //不管是否满足条件，先执行一次

            int j = 1;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            #region MyRegion

            #endregion
        }
    }
}