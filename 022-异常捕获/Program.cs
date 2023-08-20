namespace _022_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 异常捕获
            //必备部分
            try
            {
                //希望进行异常捕获的部分放这里
                //如报错，不会卡死，会跳入catch部分开始执行
            }
            catch(Exception e)
            {
                //如果出错，执行这部分代码
                //catch(Exception e) 报错跟踪，通过e得到具体错误信息
            }
            //可选部分
            finally
            {
                //不管是否出错，执行其中的代码
            }

            #endregion


            #region 实践练习
            int a = int.Parse(Console.ReadLine());

            try
            {
                int a1 = int.Parse(Console.ReadLine());
                Console.WriteLine(a1);
            } 
            catch(Exception e)
            {
                Console.WriteLine("Error.");
            }

            #endregion
        }
    }
}