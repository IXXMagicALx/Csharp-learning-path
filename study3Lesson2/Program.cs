namespace Lesson2
{
    enum E_Major
    {

    }
    struct Address
    {

    }
    class Person
    {
        string name;
        int height;
        int age;
        Address address;
    }
    class Student
    {
        string name;
        int Id;
        int age;
        Student deskMate;
    
    }
    class Class
    {
        E_Major major;
        int roomCap;
        Student[] student;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            //public 公共的 外部和自己内部都能使用
            //private 私有的 只有自己内部能使用
            //protected 保护的 只有自己内部和子类能使用
            #endregion
            #region 
            Person p0 = new Person();
            Person p1 = new Person();
            Person p2 = new Person();
            #endregion
            #region 
            Student s0 = new Student();
            Student s1 = new Student();
            Student s2 = new Student();
            #endregion
        }

    }
}
