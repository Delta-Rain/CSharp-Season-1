namespace _113_结构体练习
{
    internal class Program
    {
        //定义一个三维坐标的结构体
        struct Position
        {
            public double x;
            public double y;
            public double z;

            public void PrintPosition()
            {
                Console.WriteLine(x + " " + y + " " + z);
            }
        }
        //结构体中不但可以定义属性，也可以定义函数
        //static void PrintPostion(Position p)
        //{
        //    Console.WriteLine(p.x + " " + p.y + " " + p.z);
        //}

        struct Name
        {
            public string firstname;
            public string lastname;

            public string Fullname()
            {
                return firstname + lastname;
            }
        }
        static void Main()
        {
            Position p1;
            p1.x = 1;
            p1.y = 2.2;
            p1.z = 3.135;
            p1.PrintPosition();
            //可以通过p1.x来访问其中的属性，也可以通过p1.PrintPosition来访问其中的函数

            Name name;
            name.firstname = "三";
            name.lastname = "张";
            Console.WriteLine("My name is " + name.Fullname());

            Name name2;
            name2.firstname = "Steven";
            name2.lastname = "Jobs";
            Console.WriteLine("My name is {0}", name2.Fullname());

        }
    }
}