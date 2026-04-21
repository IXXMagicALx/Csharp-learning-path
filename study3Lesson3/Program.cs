using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Lesson3
{
    class Person
    {
        public string name;
        public int age;
        public Person[] friends;//朋友数组

        public void Speak(string str)
        {
            Console.WriteLine("{0}：{1}", name, str);
        }
        public void walk()
        {
            Console.WriteLine("{0}:没病走两步",name);
        }
        public void eat( Food food )
        {
            Console.WriteLine("{0}:我要吃{1}", name , food.name);
        }
        public bool isAdult()
        {
            return age >= 18;
        }
        public void AddFriends(Person p)
        {
            if (friends == null)//还未初始化则初始化
            {
                friends = new Person[] { p };
            }
            else
            {
                Person[] newFriends = new Person[friends.Length + 1];
                for (int i = 0; i < friends.Length; i++)
                {
                    newFriends[i] = friends[i];//搬家 
                }
                newFriends[newFriends.Length - 1] = p;
                //重定向！！
                friends = newFriends;
            }
        }
    }
    class Student
    {
        public string name;

        public void Study() 
        {
            Console.WriteLine("我,{0},好好学习，天天向上!" , name);
        }
        public void eat(string str)
        {
            Console.WriteLine("{0}:学习好了再吃{1}" , name, str);
        }
    }
    class Food
    {
        public string name;
        int caloric;
        Food [] foods;//食物数组
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法");
            Person p = new Person();
            p.name = "1";
            p.age = 11;
            
            Person p2 = new Person();
            p2.name = "2";
            p2.age = 12;
           
            p2.Speak("你好!");
            p.walk();
            //p.AddFriends(p2);//对谁调用前面点谁
            //for(int i = 0; i < p.friends.Length; i++ )
            //{
            //    Console.WriteLine(p.friends[i].name);
            //    //不.name则打印（命名空间+类名）即Lesson3.Person
            //}
            Student s = new Student();
            s.name = "3";
            s.Study();
            s.eat("烧烤");
            Food apple = new Food();//一类中的一个物品
            Food banana = new Food();
            Food pear = new Food();
            apple.name = "苹果";
            banana.name = "香蕉";
            pear.name = "梨";

            p.eat(apple);
        }
    }
}
