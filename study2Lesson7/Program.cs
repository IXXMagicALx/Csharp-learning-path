using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Lesson7
{
    internal class Program
    {
        #region 函数申明
        #region 课上函数
        ////有参数多返回
        //static float[] SumAndAvg(int a,int b)
        //{
        //    float sum = a + b;
        //    float avg = sum / 2;
        //    //float [] arr = { sum, avg };
        //    //return arr;
        //    return new float[] { sum, avg };
        //}
        //static string Speak(string str)
        //{
        //    if (str == "混蛋"||str == "阿米诺斯")
        //    {
        //        return "不说脏话，文明你我他";
        //    }
        //    Console.WriteLine(str);
        //    return "";
        //}
        #endregion
        #region 习题函数
        static int Compare(int a,int b)
        {
            //int max =0;
            //if (a>b)
            //{
            //    max = a;
            //}
            //else if (b > a)
            //{
            //    max = b;
            //}
            //return max;
            return a > b ? a : b;//但是没有等于的情况
        }
        static float[] Circle(float r)
        {
            float pi = 3.14F;
            float L = 2 * pi * r;
            float S = pi * r * r;
            return new float[] {L,S};
        }
        static int [] Calculate(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("数组不能为空");
                return new int[0];
            }
            int sum = 0, max = 0, min = 0, avg = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (i==0)
                {
                    max = arr[i];
                    min = arr[i];
                }
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
                sum+= arr[i];
                avg = sum / arr.Length;
            }
            return new int[] {sum,max,min,avg};
        }
        static bool Judge(int input)
        {
            if (input>1)
            {
                for (int i = 2; i < input; i++)//从2开始除避免除到1后不是自己然后误判
                {
                    int o = 0;
                    o = input % i;
                    if (o == 0)//能被整除且这个数不是它自己
                    {
                        return false;//return会直接跳出for循环
                    }
                }
                return true;//到自己之前都没能被整除，就是质数
            }
            
            return false;//小于等于1的都不是质数
        }
        static bool YearJudge(int year)
        {
            if (year%400==0||(year%4==0&&year%100!=0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("函数");
            #region 使用函数
            //float[]arr = SumAndAvg(5,6);
            //Console.WriteLine("和是:" + arr[0] + "平均数是:" + arr[1]);
            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    Console.WriteLine(Speak(str));
            //}
            #endregion
            #region 1.
            //Console.WriteLine("请输入一个数：");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("请再输入一个数：");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("********************************");
            //Console.WriteLine(Compare(a, b) + "更大");
            #endregion
            #region 2.
            //float r = float.Parse(Console.ReadLine());
            //float[] arr = Circle(r);
            //Console.WriteLine("圆的周长是：{0},圆的面积是:{1}", arr[0], arr[1]);
            #endregion
            #region 3.
            //int[] arr = { 11, 4, 8, 6, 9 };
            //int[] arro = Calculate(arr);
            //Console.WriteLine("数组的总和是{0}，最大值是{1}，最小值是{2}，平均值是{3}", arro[0], arro[1], arro[2], arro[3]);
            #endregion
            #region 4.
            //while (true)
            //{
            //    Console.WriteLine("***************************");
            //    try
            //    {
            //        Console.WriteLine("请输入一个整数");
            //        int input = int.Parse(Console.ReadLine());//检测输入
            //        Console.WriteLine("{0}{1}质数",input, Judge(input)?"是":"不是");//输出判断结果
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入整数！！！！\a");
            //    }
            //}
            #endregion
            #region 5.
            while (true)
            {
                Console.WriteLine("请输入一个年份");
                int year = int.Parse(Console.ReadLine());//输入年份
                Console.WriteLine("{0}{1}闰年",year,YearJudge(year)?"是":"不是");//输出判断结果
            }
            #endregion
        }
    }
}
