using System.Xml.Serialization;

namespace Lesson9
{
    static class Tools
    {
        public static void Func3(this Test value)
        {
            Console.WriteLine("为自定义的类型拓展方法");
        }
        public static void Func2(this Test value)
        {
            Console.WriteLine("为自定义的类型拓展重名的方法");
        }
    }

    class Test
    {
        public int i = 10;
        public void Func1()
        {
            Console.WriteLine("123");
        }
        public void Func2()
        {
            Console.WriteLine("456");
        }
    }
    static class MathTool
    {
        public static int Square(this int value)
        {
            return value * value;
        }
    }
    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;
        public Player()
        {
            name = "123";
            atk = 150;
            def = 25;
            hp = 100;
        }
        public void Atk()
        {
            Console.WriteLine("攻击");
        }
        public void Move()
        {
            Console.WriteLine("移动");
        }
        public void Injured()
        {
            hp -= 25;
            Console.WriteLine("处于受伤状态，剩余血量{0}",hp);
        }
    }
    static class Expand
    {
        public static void Suicide(this Player gamer , int hp)
        {
            hp = 0;
            Console.WriteLine("Wasted! 剩余血量{0}",hp);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("拓展方法");
            #region 
            //Test j = new Test();//实例化对象
            //j.Func3();
            //j.Func2();
            //j.Func1();
            #endregion
            int i = 10;
            Console.WriteLine(i.Square());
            Player gamer = new Player();
            gamer.Atk();
            gamer.Move();
            gamer.Injured();
            gamer.Suicide(gamer.hp);

        }
    }
}
