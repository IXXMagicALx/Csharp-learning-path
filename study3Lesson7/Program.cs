namespace Lesson7
{
    //单例模式
    //要求
    //请用静态成员相关知识实现
    //一个类对象，在整个应用程序的生命周期中，有且仅会有一个该对象的存在，
    //不能在外部实例化，直接通过该类类名就能够得到唯一的对象
    class Test
    {
        public static Test t = new Test();//在内部实例化一个对象
        //static能满足在整个程序的应用周期内对象都存在，且具有唯一性
        public int test = 10;
        //成员属性
        public static Test T//公开属性外部才能用 类型是Test类 属性名为T
        {
            get
            {
                return t;//返回的t是上面在内部实例化出来的对象
            }
        }
        private Test()//私有构造函数，使外部不能实例化
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态成员");

            Console.WriteLine(Test.T.test);

        }
    }
}
