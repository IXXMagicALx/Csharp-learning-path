namespace Lesson14
{
    class Person
    {
        public int iD;
    }
    class Driver:Person
    {
    }
    class Passenger:Person
    {
    }
    class Vehicle
    {
        public int speed;
        public int maxSpead;
        public int capacity;
        public Person [] persons;
        public int num;
         public Vehicle(int capacity)
        {
            speed = 60;
            maxSpead = 120;
            num = 0;//实际载客数
            this.capacity = capacity;//载客量
            persons = new Person[capacity];
        }
        public void GetOn(Person p)
        {
            if(num >= capacity)
            {
                Console.WriteLine("满载了");
                return;
            }
            else
            {
                persons[num] = p;
                num++;
                Console.WriteLine("现在车上有{0}位乘客,还有{1}个空座位", num, capacity - num);
            }
            
        }
        public void GetOff(Person p)
        {
            for(int i = 0 ; i < num ; i++)//找乘客
            {
                if (persons[i] == p)
                {
                    if (persons[i] is Driver)
                    {
                        Console.WriteLine("司机真的要下车吗\n目前地球上的智驾水平还没有达到不需要司机的水平");
                        char key = Console.ReadKey().KeyChar;
                        if('1'== key)
                        {
                            Console.WriteLine();
                            Accident();
                        }
                        return;
                    }
                    Console.WriteLine("{0}号乘客下车了",i+1);
                    for(int j = i;j < num - 1;j++)
                    {
                        persons[j] = persons[j + 1];
                    }
                    num--;
                    Console.WriteLine("现在车上还有{0}位乘客,还有{1}个空座位", num , capacity - num);
                    return;
                }
                
            }
            Console.WriteLine("该乘客不在车上");
        }
        public void Go()
        {
            Console.WriteLine("{0}行驶");
        }
        public void Accident()
        {
            Console.WriteLine("发生交通事故");
            Console.WriteLine("道路千万条，安全第一条。\n驾驶不规范，亲人两行泪。");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封类");
            Vehicle v = new Vehicle(5);
            Person p = new Driver();
            Person p1 = new Passenger();
            Person p2 = new Passenger();
            Person p3 = new Passenger();
            Person p4 = new Passenger();
            Person p5 = new Passenger();
            v.GetOn(p);
            v.GetOn(p1);
            v.GetOn(p2);
            v.GetOn(p3);
            v.GetOn(p4);
            v.GetOff(p2);
            v.GetOff(p);//司机下车
            
        }
    }
}
