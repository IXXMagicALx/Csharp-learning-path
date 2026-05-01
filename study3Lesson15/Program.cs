namespace Lesson15
{
    class Duck
    {
        public virtual void Call()
        {
            Console.WriteLine("嘎嘎叫");
        }
    }
    class WoodenDuck:Duck
    {
        public override void Call()
        {
            Console.WriteLine("吱吱叫");
        }
    }
    class RubberDuck : Duck
    {
        public override void Call()
        {
            Console.WriteLine("唧唧叫");
        }
    }
    class Employee
    {
        public virtual void Tick()
        {
            Console.WriteLine("九点打卡");
        }
    }
    class Manager:Employee
    {
        public override void Tick()
        {
            Console.WriteLine("十一点打卡");
        }
    }
    class Programmer : Employee
    {
        public override void Tick()
        {
            Console.WriteLine("不用打卡");
        }
    }
    class Figure
    {
        protected float S;
        protected float L;
        public virtual float Area()
        {
            return S; 
        }
        public virtual float Length()
        {
            return L;
        }
    }
    class Circle:Figure
    {
        private static float pI = 3.14F;
        public int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public override float Area()
        {
            S = pI*r*r;
            return S;
        }
        public override float Length()
        {
            L = pI * 2 * r;
            return L;
        }
    }
    class Square : Figure//正方形
    {
        public int sl;
        public Square(int sl)
        {
            this.sl = sl;
        }
        public override float Area()
        {
            S = sl * sl;
            return S;
        }
        public override float Length()
        {
            L = 4*sl;
            return L;
        }
    }
    class Retangle:Figure//矩形
    {
        public int l;
        public int w;
        public Retangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        public override float Area()
        {
            S = l * w;
            return S;
        }
        public override float Length()
        {
            L = 2*(l + w);
            return L;   
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多态vob");
            Duck d = new Duck();
            Duck w = new WoodenDuck();
            Duck r = new RubberDuck();
            d.Call();
            w.Call();
            r.Call();
            Employee e = new Employee();
            Employee m = new Manager();
            Employee p = new Programmer();
            e.Tick();
            m.Tick();
            p.Tick();
            Figure c = new Circle(5);
            Figure r1 = new Retangle(5,5);
            Figure s = new Square(6);
            Console.WriteLine("面积是{0}，周长是{1}", c.Area(),c.Length());
            Console.WriteLine("面积是{0}，周长是{1}", r1.Area(), r1.Length());
            Console.WriteLine("面积是{0}，周长是{1}", s.Area(), s.Length());
        }
    }
}
