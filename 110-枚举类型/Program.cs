namespace _110_枚举类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //法师、射手、刺客、辅助...，如何存储

            #region int类型
            //1法师、2射手、3刺客、4辅助
            int roleType = 2;
            roleType = 3; //更改职业
            #endregion

            RoleType newplayer = RoleType.Assassin;
            if (newplayer == RoleType.Mage)
            {
                //当作一个变量来使用
            }

        }

        #region 枚举类型
        //枚举和function一样，先定义，再使用
        enum RoleType //枚举类型的名字
        {
            Mage, Archer, Assassin, Support //枚举类型的值
        }

        #endregion
    }
}