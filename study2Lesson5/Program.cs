using System.Runtime.CompilerServices;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");
            #region 课
            //值类型和引用类型
            //引用类型： string 数组 类
            //值类型：其他+结构体
            int a = 30;
            int b = a;//b=30
            Console.WriteLine("a的值{0},b的值{1}", a, b);//b=a=30
            Console.WriteLine("********************");
            b = 50;
            Console.WriteLine("a的值{0},b的值{1}",a,b);//b=50,a=30
            Console.WriteLine("********************");
            int[] arr1 = {1,2,3,4};
            int[] arr2 = arr1;//arr2={1,2,3,4}
            arr2[0] = 5;
            Console.WriteLine("arr1[0]的值{0},arr2[0]的值{1}", arr1[0], arr2[0]);//arr2[0]=arr1[0]=5
            arr2 = new int[]{ 4, 3, 2, 1 };//arr2[0]=4
            Console.WriteLine("arr1[0]的值{0},arr2[0]的值{1}", arr1[0], arr2[0]);
            #endregion
        }
    }
}
