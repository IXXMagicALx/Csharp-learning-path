namespace Lesson4
{
    class Person
    {
        public string name;
        public int age;

        public Person()//无参数构造函数
        {
            name = "小Q";
            age = 16;
        }
        public Person(string name)//单参数构造函数
        {
            this.name = name;
        }
        public Person(string name , int age)//双参数构造函数
        {
            this.name = name;
            this.age = age;
        }
        public void Speak(Person p)
        {
            Console.WriteLine("我是{0}，我{1}岁",name,age);
        }
    }
    class Class
    {
        string major;
        int roomCap;
        public Person [] people; 
        public Class()
        {
            roomCap = 30;
            major = "A";
        }
        public Class(int roomCap):this()//专业同容量不同
        {
            this.roomCap = roomCap;
        }
        public Class(string major) : this()//容量同专业不同
        {
            this.major = major;
        }
        public void Speak(Class c)
        {
            Console.WriteLine("{0}专业有{1}人，其中有{2}", major, roomCap, people[0].name);
        }
    }
    class Ticket
    {
        float price;
        public uint distance;
        public Ticket(uint distance)
        {
            this.distance = distance;
            price = GetPrice(); 
        }
        float GetPrice()
        {
            //更简洁
            float discount = distance > 300 ? 0.8F :
                              distance > 200 ? 0.9F :
                              distance > 100 ? 0.95F : 1.0F;
            return price = discount * distance;
        }
        public void PrintInfo()
        {
            Console.WriteLine("这一段路程走了{0}公里要花{1}元", distance, price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数和析构函数");
            Person p0 = new Person();
            Person p1 = new Person("小A");
            Person p2 = new Person("小Z", 18);
            p0.Speak(p0);
            p1.Speak(p1);
            p2.Speak(p2);
            Class c0 = new Class();
            Class c1 = new Class(40);
            Class c2 = new Class("C");
            c0.people = new Person[] { p0 };//小Q
            c1.people = new Person[] { p1 };//小A
            c2.people = new Person[] { p2 };//小Z
            c0.Speak(c1);
            c1.Speak(c2);
            c2.Speak(c2);
            Ticket t0 = new Ticket(101);
            t0.PrintInfo();
        }
    }
}
