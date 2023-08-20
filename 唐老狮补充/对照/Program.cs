using System;

namespace 入门实践
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 控制台基础设置
            //隐藏光标
            Console.CursorVisible = false;
            //通过两个变量来存储 舞台的大小
            int w = 50;
            int h = 30;
            //设置舞台（控制台）的大小
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            #endregion

            #region 2 多个场景
            //当前所在场景的编号
            int nowSceneID = 1;
            while (true)
            {
                //不同的场景ID 进行不同的逻辑处理
                switch (nowSceneID)
                {
                    //开始场景
                    case 1:
                        Console.Clear();
                        #region 3 开始场景逻辑
                        Console.SetCursorPosition(w / 2 - 7, 8);
                        Console.Write("唐老狮营救公主");
                        //当前选项的编号
                        int nowSelIndex = 0;
                        //因为要输入 我们可以构造一个 开始界面自己的 死循环
                        //专门用来处理 开始场景相关的逻辑
                        while (true)
                        {
                            //用一个标识  来处理 想要在while循环内部的switch逻辑执行时 希望退出外层while循环时
                            // 改变标识即可
                            bool isQuitWhile = false;
                            // 显示 内容
                            //先设置光标位置 再显示内容
                            Console.SetCursorPosition(w / 2 - 4, 13);
                            //根据当前选择的编号 来决定 是否变色
                            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            Console.SetCursorPosition(w / 2 - 4, 15);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");
                            // 检测 输入
                            // 检测玩家 输入的一个键内容 并且不会再控制台上显示输入的内容
                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'W':
                                case 'w':
                                    --nowSelIndex;
                                    if (nowSelIndex < 0)
                                    {
                                        nowSelIndex = 0;
                                    }
                                    break;
                                case 'S':
                                case 's':
                                    ++nowSelIndex;
                                    if (nowSelIndex > 1)
                                    {
                                        nowSelIndex = 1;
                                    }
                                    break;
                                case 'J':
                                case 'j':
                                    if (nowSelIndex == 0)
                                    {
                                        //1.改变当前选择的场景ID
                                        nowSceneID = 2;
                                        //2.要退出 内层while循环
                                        isQuitWhile = true;
                                    }
                                    else
                                    {
                                        //关闭控制台
                                        Environment.Exit(0);
                                    }
                                    break;
                            }

                            if (isQuitWhile)
                            {
                                break;
                            }
                        }
                        #endregion
                        break;
                    //游戏场景
                    case 2:
                        Console.Clear();

                        #region 4 不变的红墙
                        //设置颜色为红色
                        Console.ForegroundColor = ConsoleColor.Red;
                        //画墙
                        //上方墙
                        for (int i = 0; i < w; i += 2)
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
                        ////下方墙
                        //for (int i = 0; i < w; i += 2)
                        //{
                        //    Console.SetCursorPosition(i, h - 1);
                        //    Console.Write("■");
                        //}
                        ////中间墙
                        //for (int i = 0; i < w; i += 2)
                        //{
                        //    Console.SetCursorPosition(i, h - 6);
                        //    Console.Write("■");
                        //}
                        //左边的墙
                        for (int i = 0; i < h; i++)
                        {
                            //左边的墙
                            Console.SetCursorPosition(0, i);
                            Console.Write("■");
                            //右边的墙
                            Console.SetCursorPosition(w - 2, i);
                            Console.Write("■");
                        }
                        ////右边的墙
                        //for (int i = 0; i < h; i++)
                        //{
                        //    Console.SetCursorPosition(w-2, i);
                        //    Console.Write("■");
                        //}
                        #endregion

                        //游戏场景的死循环 专门用来 检测 玩家输入相关循环
                        while (true)
                        {

                        }
                        break;
                    //结束场景
                    case 3:
                        Console.Clear();
                        Console.WriteLine("结束场景");
                        break;
                }
            }
            #endregion
        }
    }
}
