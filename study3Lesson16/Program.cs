namespace Lesson16
{
    abstract class Animal
    {
        public abstract void Call();
    }
    class Person:Animal
    {
        public override void Call()
        {
            Console.WriteLine("人说话");
        }
    }
    class Dog:Animal
    {
        public override void Call()
        {
            Console.WriteLine("狗叫");
        }
    }
    class Cat:Animal
    {
        public override void Call()
        {
            Console.WriteLine("猫叫");
        }
    }
    abstract class Figure
    {
        protected float S;
        protected float L;
        public abstract float Area();
        public abstract float Length();
    }
    class Circle : Figure
    {
        private static float pI = 3.14F;
        public int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public override float Area()
        {
            S = pI * r * r;
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
            L = 4 * sl;
            return L;
        }
    }
    class Retangle : Figure//矩形
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
            L = 2 * (l + w);
            return L;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象函数");

            Animal p = new Person();
            Animal d = new Dog();
            Animal c = new Cat();
            p.Call();
            d.Call();
            c.Call();
            Figure c1 = new Circle(5);
            Figure r1 = new Retangle(5, 5);
            Figure s = new Square(6);
            Console.WriteLine("面积是{0}，周长是{1}", c1.Area(), c1.Length());
            Console.WriteLine("面积是{0}，周长是{1}", r1.Area(), r1.Length());
            Console.WriteLine("面积是{0}，周长是{1}", s.Area(), s.Length());
        }
    }
}
