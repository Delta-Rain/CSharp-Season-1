namespace _115_委托
{
    internal class Program
    {
        //委托 delegate，存储函数引用的类型
        //先定义，再指向某个funciton，然后调用该function
        //指向的function和该delegate返回值、参数类型相同

        static double Multiply(double param1, double param2)
        {
            return param1 * param2; //函数体
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2; //函数体
        }

        delegate double MyDelegate(double param1, double param2); //没有函数体

        static void Test()
        {
            Console.WriteLine("Test");
        }
        delegate void MyDelegate2(); //指向任何返回值为空，参数为空的函数
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2.3, 2));
            Console.WriteLine(Divide(3, 1.5));

            MyDelegate delegate1;
            delegate1 = Multiply; 
            //delegate1指向了函数Multiply，delegate就可以当作一个function来使用
            //且必须先指向某个function，不然不知道该调用哪个
            Console.WriteLine(delegate1(2, 4)); //8
            delegate1 = Divide;
            Console.WriteLine(delegate1(2, 4)); //0.5

            MyDelegate2 delegate2;
            delegate2 = Test;
            delegate2();


        }
    }
}