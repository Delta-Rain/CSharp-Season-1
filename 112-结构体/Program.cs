namespace _112_结构体
{
    internal class Program
    {
        //结构体和function一样，需要先定义再使用
        struct StudentInfo
        {
            public int age;
            public string name;
            public int grade;
            public int id;
        }
        static void Main(string[] args)
        {
            int student1Age = 10;
            string student1Name = "siki";
            int student1Grade = 3;
            int student1ID = 123;

            int student2Age = 11;
            string student2Name = "rag";
            int student2Grade = 2;
            int student2ID = 1234;

            StudentInfo student1;
            student1.age = 10;
            student1.name = "Xiaoming";
            student1.grade = 3;
            student1.id = 12314;

            //Console.WriteLine(student1.name); //得到 Xiaoming

            //可以创建结构体类型的数组
            StudentInfo[] students = new StudentInfo[10]; //10个学生
            students[0].age = 30;
            Console.WriteLine(students[0].age);
        }
    }
}