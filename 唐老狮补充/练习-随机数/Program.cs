using System.ComponentModel.Design;

namespace 练习_随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //唐老狮打小怪兽
            //唐老狮攻击力8-12
            //小怪兽防御力10，血量20
            //打印打怪过程
            //描述小怪兽掉血情况
            //伤害计算公式：攻击力＜防御力，减血为0，否则减血为攻击力防御力的差值

            Random atk = new Random();
            const int enemy_def = 10;
            int enemy_hp = 20;
            int count = 1;

            Console.WriteLine("按任意键开始游戏");
            Console.ReadKey();
            Console.WriteLine("小怪兽初始血量为20，防御力为10");
            Console.WriteLine();
            while (enemy_hp > 0)
            {
                int atk_random = atk.Next(8, 13);
                Console.WriteLine("第{0}回合开始————", count);
                if (atk_random <= enemy_def)
                {
                    Console.WriteLine("本轮攻击力为{0}", atk_random);
                    Console.WriteLine("小怪兽未受伤，剩余血量：{0}", enemy_hp);
                }
                else
                {
                    Console.WriteLine("本轮攻击力为{0}", atk_random);
                    enemy_hp = enemy_hp - (atk_random - enemy_def);
                    Console.WriteLine("小怪兽受伤了！剩余血量：{0}", enemy_hp);
                }
                count++;
                if (enemy_hp < (atk_random - enemy_def))
                {
                    Console.WriteLine("小怪兽倒了（悲");
                }
                Console.WriteLine("\n按任意键开始下一轮游戏");
                Console.ReadKey();
            } 

        }
    }
}