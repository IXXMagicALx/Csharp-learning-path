namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊引用类型");
            #region 课
            //string str1 = "123";
            //string str2 = str1;
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine("***********************");
            //str2 = "456";
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            #endregion
            #region 1.
            int[] a = {10};
            int[] b = a;
            b = new int[5];//{0,0,0,0,0}
            Console.WriteLine(a[0]);
            #endregion
        }
    }
}
