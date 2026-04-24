namespace Lesson8
{
    static class StaticClass
    {
        public static int testInt = 100;
        public static int testInt2 = 100;
        static StaticClass()
        {
            Console.WriteLine("静态构造函数");
             testInt = 200;
            testInt2 = 300;
        }
    }
    static class MathTool
    {
        private static float Pi = 3.14F;
        /// <summary>
        /// 计算圆的面积
        /// </summary>
        /// <param name="r">圆的半径</param>
        public static void CS(int r)
        {
            float S = Pi * r * r;
            Console.WriteLine("半径为{0},圆面积为:{1}",r,S);
        }
        /// <summary>
        /// 计算圆的周长
        /// </summary>
        /// <param name="r">圆的半径</param>
        public static void CL(int r)
        {
            float L = 2 * Pi * r;
            Console.WriteLine("半径为{0},圆周长为:{1}", r, L);
        }
        /// <summary>
        /// 计算正方形的面积
        /// </summary>
        /// <param name="r">正方形的半边长</param>
        public static void RS(int r)
        {
            int S = 2*r*2*r;
            Console.WriteLine("边长为{0},正方形面积为:{1}", 2*r, S);
        }
        /// <summary>
        /// 计算正方形的周长
        /// </summary>
        /// <param name="r">正方形的半边长</param>
        public static void RL(int r)
        {
            int L = 4 * 2 * r;
            Console.WriteLine("边长为{0},正方形周长为:{1}", 2*r, L);

        }
        /// <summary>
        /// 取对输入的数取绝对值
        /// </summary>
        /// <param name="value"></param>
        public static void AbsoluteValue(int value)
        {
            if (value < 0)
            {
                value = -value;
            }
            Console.WriteLine("对它取绝对值的结果是" + value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("静态类和静态构造函数");
            //Console.WriteLine(StaticClass.testInt);
            //Console.WriteLine(StaticClass.testInt2);
            Console.WriteLine("请输入一个数计算面积和周长");
            int r = int.Parse(Console.ReadLine());
            MathTool.CS(r);
            MathTool.CL(r);
            MathTool.RS(r);
            MathTool.RL(r);
            MathTool.AbsoluteValue(int.Parse(Console.ReadLine()));
        }
    }
}
