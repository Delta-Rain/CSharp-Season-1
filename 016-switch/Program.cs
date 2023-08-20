namespace _016_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32 (Console.ReadLine());
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("矿泉水");
            //        break;
            //    case 2:
            //        Console.WriteLine("红茶");
            //        break;
            //    case 3:
            //        Console.WriteLine("雪碧");
            //        break;
            //    default: 
            //        Console.WriteLine("脉动");
            //        break;
            //        //需要判断数值范围时用if，直接判断固定数值用switch


            int weekdate = Convert.ToInt32(Console.ReadLine());
            switch (weekdate)
            {
                case 1:
                case 2:
                    Console.WriteLine("Arduino");
                    break;
                case 3:
                    Console.WriteLine("C#");
                    break;
            }
        }
    }
}