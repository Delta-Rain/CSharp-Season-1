namespace _011_逻辑运算符的优先级
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 3 + 2 * 8;
            //Console.WriteLine(a); //加减乘除

            //Console.WriteLine("请输入年龄，我来判断是否是青年（18-60岁）。");
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool ageTF = age >= 18 && age <= 60; //先关系运算，再逻辑运算
            //Console.WriteLine(ageTF);

            //int a1 = 3;
            //int b = a1++ + a1++;
            //Console.WriteLine(b);

            //题：数学英语都考到90才有奖励
            int mathsScore = Convert.ToInt32(Console.ReadLine());
            int englishScore = Convert.ToInt32(Console.ReadLine());
            bool a = mathsScore >= 90 && englishScore >= 90;
            Console.WriteLine(a);


        }
    }
}