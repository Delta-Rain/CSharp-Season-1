namespace _111_枚举类型练习
{
    internal class Program
    {
        //枚举列表中的每个符号，代表一个整数值，比前一个符号大的值
        //默认情况下，第一个符号的值为0
        //可修改默认值
        //枚举类型相当于整数int类型
        enum GameStatus
        {
            Menu, Running, Pause, Fail, Success
        }
        enum Weekdays
        {
            Sun, Mon = 120, Tue = 100, Wed = 10, Thu, Fri = 100, Sat
        }
        static void Main(string[] args)
        {
            //使用枚举表示游戏状态（菜单、游戏中、暂停、失败、成功）
            GameStatus status = GameStatus.Running;
            status = GameStatus.Pause;
            Console.WriteLine(status);

            Weekdays day = Weekdays.Sun;
            day = Weekdays.Mon;
            

        }
    }
}