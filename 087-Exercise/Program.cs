namespace _087_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////3个瓶子换一瓶可乐，现有364瓶，共喝多少瓶，剩下几个瓶子
            //int pingNum = 364; //瓶子pingNum个
            //int heNum = 364; //喝了heNum瓶
            //while (pingNum >= 3)
            //{
            //    heNum = heNum + pingNum / 3;
            //    pingNum = pingNum / 3 + pingNum % 3;
            //    //5个瓶子 heNum=5
            //    //一轮后 2个空瓶(ping%3)+1新瓶(ping/3) 3空瓶(ping/3+ping%3) heNum = 原+ping/3
            //    //二轮 1新瓶(ping/3) henum=原+ping/3
            //}
            //Console.WriteLine("共喝了{0}瓶，剩下{1}个瓶子。", heNum, pingNum);

            //加密，a-d, b-e, w-z ... A-D, B-E, W-Z
            //string str = "Hello World";
            ////数组可以修改里面的数字，字符串不行
            ////所以str[3] = '3' 不行
            //char[] strArray = str.ToCharArray(); //把字符串转化为字符数组
            //strArray[3] = 'a';

            string str = Console.ReadLine();
            char[] strArray = str.ToCharArray();
            for(int i = 0; i < strArray.Length; i++)
            {
                if ((strArray[i] >= 'a' && strArray[i] <= 'z') || (strArray[i] >= 'A' && strArray[i] <= 'Z')) 
                    //满足条件说明是小写字母
                    //或 说明要么是小写字母 要么是大写 总之是字母
                {
                    strArray[i] = (char)(strArray[i] + 3);
                    //'a'+3 即97+3 100，对应'd'
                    if (strArray[i] > 'z' && strArray[i] < 'z' + 4)
                    {
                        strArray[i] = (char)(strArray[i] - 26);
                    }
                    if (strArray[i] > 'Z' && strArray[i] < 'Z' + 4)
                    {
                        strArray[i] = (char)(strArray[i] - 26);
                    }
                }
            }

            foreach(char temp in strArray)
            {
                Console.Write(temp);
            }




        }
    }
}