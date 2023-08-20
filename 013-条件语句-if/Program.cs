namespace _013_条件语句_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////16岁及以下免费
            //int age = Convert.ToInt32(Console.ReadLine());

            ////if语句
            //if (age<=16) {
            //    //满足条件则运行
            //    Console.WriteLine("免费");
            //}
            //else
            //{
            //    Console.WriteLine("收费");
            //}

            ////判断基数还是偶数
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("偶数");
            //}
            //else
            //{
            //    Console.WriteLine("奇数");
            //}

            //18-30岁之间，且奇数才可领奖
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age>=18 && age<=30 && age%2==1)
            //{
            //    Console.WriteLine("领奖");
            //}
            //else
            //{
            //    Console.WriteLine("无奖")；
            //}

            //嵌套
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("可参加");
                if (age % 2 == 1)
                {
                    Console.WriteLine("领奖！");
                }
                else
                {
                    Console.WriteLine("痛失大酱");
                }
            }
            else
            {
                Console.WriteLine("不可参加");
            }
        }
    }
}