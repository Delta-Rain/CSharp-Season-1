namespace 练习_WASD控制黄点移动
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //改变背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();

            //改变字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;

            //隐藏光标
            Console.CursorVisible = false;

            //黄色方块上有坐标信息
            int x = 0;
            int y = 0;


            //不停输入wasd控制移动
            while (true)
            {
                Console.Clear(); //清空之前信息
                Console.SetCursorPosition(x, y);
                Console.WriteLine("■");
                //得到玩家输入信息
                char a = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("  ");
                switch (a)
                {
                    //贯穿
                    case 'W':
                    case 'w':
                        y -= 1;
                        //改变位置后，判断是否越界
                        if (y < 0)
                        {
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        x -= 2; //中文符号占两个位置
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        if (y > Console.BufferHeight - 1)
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if (x > Console.BufferWidth - 2)
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;

                }
            }

        }
    }
}