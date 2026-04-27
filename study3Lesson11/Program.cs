namespace Lesson11
{
    class Humankind
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public void Speak()
        {
            Console.WriteLine("我的名字叫" + Name);
        }
    }
    class Warrior:Humankind
    {
        public void Fight()
        {
            Console.WriteLine("攻击");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本概念");
            Warrior w = new Warrior();
            w.Name = "123";

        }
    }
}
