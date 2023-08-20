namespace _05_练习_救公主
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 设置控制台
            //隐藏光标
            Console.CursorVisible = false;
            //变量存储控制台大小
            int w = 50;
            int h = 30;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            #endregion

            #region 2 多个场景
            //当前所在场景编号
            int nowSceneID = 1;
            while (true)
            {
                //不同场景对应不同逻辑
                switch (nowSceneID)
                {
                    #region 2.1 开始场景
                    //开始场景
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(w / 2 - 6, 8);
                        Console.WriteLine("华老师救女神");
                        //当前选项的编号
                        int nowSelIndex = 0;
                        //构造开始界面的死循环
                        while (true)
                        {
                            //用一个标识来处理while内部的switch、if、while，以退出整个外层
                            bool isExit = false;
                            //先设置光标位置
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red: ConsoleColor.White;
                            Console.WriteLine("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.WriteLine("退出游戏");
                            //检测玩家输入的键，且不会在console显示
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0) nowSelIndex = 0;
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1) nowSelIndex = 1;
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //1 改变当前场景ID
                                        nowSceneID = 2;
                                        //2 退出内层while
                                        isExit = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }
                            if (isExit)
                            {
                                break;
                            }
                        }
                        break;
                    #endregion

                    #region 2.2 游戏场景

                    #endregion
                    //游戏场景
                    case 2:
                        Console.Clear();
                        #region 2.2.1 红墙
                        Console.ForegroundColor= ConsoleColor.Red;
                        //画墙
                        for (int i = 0; i < w; i+=2)
                        {
                            //上方墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            //下方墙
                            Console.SetCursorPosition(i, h - 1);
                            Console.Write("■");
                            //中间墙
                            Console.SetCursorPosition(i, h - 6);
                            Console.Write("■");
                        }
                        for (int i = 0; i < h; i++)
                        {
                            //左边墙
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                            //右边墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        #endregion

                        #region 2.3 BOSS相关
                        int bossX = 24;
                        int bossY = 14;
                        int bossAtkMin = 7;
                        int bossAtkMax = 15;
                        int bossHp = 100;
                        string bossIcon = "▲";
                        //声明颜色变量
                        ConsoleColor bossColor = ConsoleColor.Green;

                        //游戏场景的死循环，用于检测玩家输入
                        while (true)
                        {
                            #region Boss属性
                            //boss活着才绘制
                            if (bossHp > 0)
                            {
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.WriteLine(bossIcon);
                            }
                            #endregion

                            #region 玩家属性
                            int playerX = 4;
                            int playerY = 5;
                            int playerAtkMin = 8;
                            int playerAtkMax = 12;
                            int playerHp = 100;
                            string playerIcon = "●";
                            ConsoleColor playerColor = ConsoleColor.Yellow;
                            char playerInput;
                            #endregion

                            #region 玩家移动
                            Console.SetCursorPosition(playerX, playerY);
                            Console.ForegroundColor = playerColor;
                            Console.Write(playerIcon);
                            playerInput = Console.ReadKey(true).KeyChar;
                            //擦除
                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write("  ");
                            //改位置
                            switch(playerInput)
                            {
                                case 'W':
                                case 'w':
                                    --playerY;
                                    if (playerY < 1) 
                                        playerY = 1;
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0) 
                                        ++playerY;
                                    break;
                                case 'A':
                                case 'a':
                                    playerX -= 2; //中文符号占两个位置
                                    if (playerX < 2) 
                                        playerX = 2;
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0) 
                                        playerX += 2;
                                    break;
                                case 'S':
                                case 's':
                                    playerY += 1;
                                    if (playerY > h - 7) 
                                        playerY = h - 7;
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0) 
                                        playerY -= 1;
                                    break;
                                case 'D':
                                case 'd':
                                    playerX += 2;
                                    if (playerX > w - 4) playerX = w - 4;
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                        playerX -= 2;
                                    break;
                            }
                            #endregion
                        }
                        #endregion

                        break;
                    //结束场景
                    case 3:
                        Console.Clear();
                        break;
                }
            }
            #endregion
        }
    }
}