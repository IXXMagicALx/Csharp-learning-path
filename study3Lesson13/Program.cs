namespace Lesson13
{
    class Worker
    {
        public string type;
        public string content;
        public Worker(string type,string content)
        {
            this.type = type;
            this.content = content;
        }
        public void Work()
        {
            Console.WriteLine("我是{0}负责{1}", type, content);
        }
    }
    class GameProgrammer : Worker
    {
        public GameProgrammer() : base("程序", "编程")
        {
            
        }

    }
    class GameDesigner : Worker
    {
        public GameDesigner() : base("策划", "设计游戏")
        {

        }
    }
    class GameArtist : Worker
    {
        public GameArtist() : base("美术", "画画")
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承中的构造函数");
            GameProgrammer gp = new GameProgrammer();
            GameDesigner gd = new GameDesigner();
            GameArtist ga = new GameArtist();
            gp.Work();
            gd.Work();
            ga.Work();
        }
    }
}
