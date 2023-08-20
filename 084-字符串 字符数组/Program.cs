namespace _084_字符串_字符数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "Raggie";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.Write(name[i] + " ");
            //}

            //string nickName = " Rain Liu ";
            //string nickName2 = nickName.ToLower(); //不会对原字符串产生影响
            //string nickName3 = nickName.ToUpper();
            //Console.WriteLine(nickName2 + " "+ nickName3) ;

            //string nickName4 = nickName.Trim(); //去掉前后空格 .TrimStart  .TrimEnd
            //Console.WriteLine(nickName4);

            string names = "Rain, Liu, Raggie";
            string[] strArray = names.Split(",");
            foreach (string name in strArray)
            {
                Console.WriteLine(name.Trim());
            }





        }
    }
}