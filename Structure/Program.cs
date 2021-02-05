using System;

struct Student
{

    public string Name;
    public int Age;
    public string Sex;
}
namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1;
            Student Student2;

            Student1.Name = "Truong Cong Khuong";
            Student1.Age = 19;
            Student1.Sex = "Male";

            Student2.Name = "Nguyen Van Thinh";
            Student2.Age = 22;
            Student2.Sex = "Female";

            Console.WriteLine("Information of student 1: ");
            Console.WriteLine("Name: {0}", Student1.Name);
            Console.WriteLine("Age: {0}", Student1.Age);
            Console.WriteLine("Sex: {0}", Student1.Sex);

            Console.WriteLine("Information of student 2: ");
            Console.WriteLine("Name: {0}", Student2.Name);
            Console.WriteLine("Age: {0}", Student2.Age);
            Console.WriteLine("Sex: {0}", Student2.Sex);
        }
    }
}
