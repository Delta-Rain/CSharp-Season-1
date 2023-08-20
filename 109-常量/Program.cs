using System.Data;

namespace _109_常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 20; //i是变量，20是常量
            const int j = 30;
            //j = 40; 不行 因为j已经是常量30


            //举例π
            const double PI = 3.141592;//常量所有字母都大写
            double temp = PI * 10;
        }
    }
}