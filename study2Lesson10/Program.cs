namespace Lesson10
{
    internal class Program
    {
        #region 知识点
        static void CalcSum(int a,int b,int c)
        {

        }
        //数量不同
        static void CalcSum(int a,int b)
        {

        }
        //类型不同
        static void CalcSum(int a, float b)
        {

        }
        //顺序不同
        static void CalcSum(float a,int b)
        {

        }
        //ref和out算一种新的变量类型，且二者是同一种类型
        static void CalcSum(out int a,float b)
        {
            a = 3;
        }
        //可选参数(即参数有默认值)不能用于重载，因为变量类型没变
        #endregion
        #region 题目
        static int Compare1(int a,int b)
        {
            Console.WriteLine( a +" "+ b );
            return (a > b ? a : b);
        }
        static float Compare1(float a, float b)
        {
            Console.WriteLine("*************************");
            Console.WriteLine(a + " " + b);
            return (a > b ? a : b);
        }
        static double Compare1(double a, double b)
        {
            Console.WriteLine("*************************");
            Console.WriteLine(a + " " + b);
            return(a > b ?  a :  b);
        }
        static int Compare2(params int[] arr)//比较n个int
        {
            Console.WriteLine("*************************");
            int max = 0;
            max = arr[0];
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("");
            return max; 
        }
        static float Compare2(params float[] arr)//比较n个float
        {
            Console.WriteLine("*************************");
            float max = 0;
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("");
            return max;
        }
        static double Compare2(params double[] arr)//比较n个double
        {
            Console.WriteLine("*************************");
            double max = 0;
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("");
            return max;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("函数重载");
            Console.WriteLine("*************************");
            Console.WriteLine(Compare1(9, 100));
            Console.WriteLine(Compare1(3.6F, 2.5F));
            Console.WriteLine(Compare1(6.7, 2.4));

            Console.WriteLine(Compare2(80, 96, 107, 308));
            Console.WriteLine(Compare2(4.5F, 8.8F, 8.11F, 8.17F));
            Console.WriteLine(Compare2(9.9, 9.87, 10.5, 80.4));
        }
    }
}
