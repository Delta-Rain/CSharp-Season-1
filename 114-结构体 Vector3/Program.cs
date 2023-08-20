namespace _114_结构体_Vector3
{
    internal class Program
    {
        struct Vector3
        {
            public double x; public double y; public double z;
            public double Distance()
            {
                double temp = x * x + y * y + z * z;
                return Math.Sqrt(temp);
            }
        }
        static void Main(string[] args)
        {
            Vector3 v1;
            v1.x = 1;
            v1.y = 0;
            v1.z = 1; //必须全部赋值完才能使用结构体中的funtion
            Console.WriteLine(v1.Distance());
        }
    }
}