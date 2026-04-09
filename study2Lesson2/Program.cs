using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组");
            #region 课
            //int [] arr = { 1, 2, 3, 4 };
            //int[] arr1 = new int [] {1,2,3,4,5};
            ////得数组的长度
            //Console.WriteLine("**********************");
            //Console.WriteLine(arr1.Length);//Length=5
            ////获取数组中的元素
            //Console.WriteLine("**********************");
            //Console.WriteLine(arr1[0]);
            ////修改数组中的元素
            //arr1[4] = 1;
            ////遍历数组
            //Console.WriteLine("**********************");
            //for (int i=0;i<arr1.Length;i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            ////增加数组元素
            //Console.WriteLine("**********************");
            //int[] arr2 = new int[6];
            //for(int i=0;i<arr1.Length ;i++ )
            //{
            //    arr2 [i] = arr1 [i];//搬家
            //}
            //arr1 = arr2;
            //for(int i = 0;i<arr1.Length ;i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            ////减少数组元素
            //Console.WriteLine("**********************");
            //int [] arr3 = new int[5];
            //for (int i = 0; i < arr3.Length; i++)//与增加的不同之处所在
            //{
            //    arr3[i] = arr1[i];
            //}
            //arr1 = arr3;
            //for(int i=0;i<arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            ////查找数族元素
            //Console.WriteLine("**********************");
            //int a = 4;
            //for(int i=0;i < arr1.Length ; i++)
            //{
            //    if (a == arr1[i])
            //    {
            //        Console.WriteLine("arr1这个数组中第{0}位是4",i);
            //    }
            //}
            #endregion
            #region 1.
            //int[] arr1 = new int[100];//长度为100的数组
            //for (int i = 0; i < arr1.Length; i++)//下标从零开始
            //{
            //    arr1[i] = i;//为数组每一个量赋值
            //}
            //for (int i = 0; i < arr1.Length; i++)//遍历数组
            //{
            //    Console.WriteLine(arr1[i]);
            //}
            #endregion
            #region 2.
            //int[] arr2 = new int[100];//长度为100的数组
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = 2 * arr1[i];
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            #endregion
            #region 3.随机（1-100）生成1个长度为10的整数数组
            //Random r = new Random();
            //int[] arr3 = new int[10];
            //for (int j = 0; j < arr3.Length; j++)
            //{
            //    int i = r.Next(1, 101);
            //    arr3[j] = i;
            //}
            //for (int j = 0; j < arr3.Length; j++)
            //{
            //    Console.WriteLine(arr3[j]);
            //}
            #endregion
            #region 4.
            #region 思路一
            ////给数组填数
            //Random r = new Random();
            //int[] arr4 = new int[10];
            //for (int j = 0; j < arr4.Length; j++)
            //{
            //    int i = r.Next(1, 101);
            //    arr4[j] = i;
            //}
            //for (int j = 0; j < arr4.Length; j++)
            //{
            //    Console.WriteLine(arr4[j]);
            //}
            //int max = arr4[0], min = arr4[0];//一开始默认第一个数最大最小 
            //int sum = 0;
            //double avg = 0;
            //for (int j = 0; j < arr4.Length; j++)
            //{
            //    if (arr4[j] > max)//当前值比max大，当前值变成max
            //    {
            //        max = arr4[j];
            //    }
            //    if (arr4[j] < min)//当前值比min小，当前值变成min
            //    {
            //        min = arr4[j];
            //    }

            //    sum += arr4[j];
            //}
            //avg = sum / arr4.Length;//不保留小数
            //Console.WriteLine("最大值是：{0}，最小值：{1}，总和：{2}，平均值:{3}", max, min, sum, avg);
            #endregion
            #region 思路二
            //Random r = new Random();
            //int[] arr4 = new int[10];
            //int max = 0, min = 0, sum = 0;
            //float avg = 0;
            //for (int j = 0; j < arr4.Length; j++)
            //{
            //    int i = r.Next(1, 101);//1~100
            //    arr4[j] = i;
            //    if (j==0)
            //    {
            //        max = arr4[j];
            //        min = arr4[j];//此处思路1和思路2有区别
            //    }
            //    if (arr4[j] > max)
            //    {
            //        max = arr4[j];
            //    }
            //    if (arr4[j] < min)
            //    {
            //        min = arr4[j];
            //    }
            //    sum += arr4[j];
            //}
            ////打印
            //for (int j = 0; j < arr4.Length; j++)
            //{
            //    Console.WriteLine(arr4[j]);
            //}
            //avg = sum / arr4.Length;//只保留整数
            //Console.WriteLine("最大值是：{0}，最小值：{1}，总和：{2}，平均值:{3}", max, min, sum, avg);
            #endregion
            #endregion
            #region 5.
            //Random r = new Random();
            //int[] arr5 = new int[7];
            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    int j = r.Next(0,100);//0~99
            //    arr5[i] = j;
            //    Console.WriteLine(arr5[i]);
            //}
            //Console.WriteLine("**********************");
            ////找中间商
            //for (int x = 0;x<(arr5.Length)/2 ;x++)//x + y = arr.Length - 1;
            //{
            //    int y = arr5.Length - 1 - x ;//不能在for循环的括号里定义，因为y会随着x变化而改变
            //    int temp = arr5[x];//数1给中间
            //    arr5[x] = arr5[y];//交换
            //    arr5[y] = temp;
            //}
            //Console.WriteLine("**********************");
            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    Console.WriteLine(arr5[i]);
            //} 
            #endregion
            #region 6.
            //Random r = new Random();
            //int[] arr6 = new int[7];
            //Console.WriteLine("*********************");
            //for (int i = 0; i < arr6.Length; i++)
            //{
            //    int j = r.Next(-20, 20);//取随机数
            //    arr6[i] = j;
            //    Console.WriteLine(arr6[i]);//遍历变之前的数组
            //    if (arr6[i] < 0)//小于0减一
            //    {
            //        arr6[i] -= 1;
            //    }
            //    else if (arr6[i] > 0)//大于0加一
            //    {
            //        arr6[i] += 1;
            //    }
            //}
            //Console.WriteLine("*********************");
            //for (int i = 0; i < arr6.Length; i++)
            //{
            //    Console.WriteLine(arr6[i]);//遍历数组
            //}
            #endregion
            #region 7.
            // int sum = 0, max = 0, min = 0;
            // double avg = 0;
            // byte grade = 0;
            // byte[] arr7 = new byte[10];//10元素 数组
            // Console.WriteLine("你要录入{0}人的成绩", arr7.Length);

            //for (int i = 0; i < arr7.Length; i++)
            //{
            //       try
            //       {
            //         Console.WriteLine("**********************");
            //         Console.WriteLine("请输入第{0}名同学的成绩:",i+1);
            //         grade = byte.Parse(Console.ReadLine());//字符串转byte记录输入
            //         arr7[i] = grade;//随机数数组
            //         if (i == 0)
            //         {
            //             max = arr7[i];
            //             min = arr7[i];
            //         }
            //         if (arr7[i] > max)
            //         {
            //             max = arr7[i];
            //         }
            //         if (arr7[i] < min)
            //         {
            //             min = arr7[i];
            //         }
            //             sum += arr7[i];
            //       }
            //       catch
            //       {
            //         Console.WriteLine("请输入数字！");
            //         i--;
            //         continue;
            //       }
            // }
            // avg = sum / arr7.Length;
            // Console.WriteLine("*****************************************************************");
            // Console.WriteLine("成绩最大值是：{0}，最小值：{1}，总和：{2}，平均值:{3}", max, min, sum, avg);
            #endregion
            #region 8.
            //给数组内容
            char[] arr8 = new char[25];
            for (int i = 0; i < arr8.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr8[i] = '■';//(0,2,4,6,8,10...)
                }
                if (i % 2 != 0)
                {
                    arr8[i] = '□';//(1,3,5,7,9,11...)
                }
            }

            int x = 0;//计数25个
            //打印数组
            for (int i = 0; i < 5; i++)//行数
            {
                for (int j = 0; j < 5; j++)//列数
                {
                    Console.Write(arr8[x]);
                    x++;
                }
                Console.WriteLine("");//换行
            }
            #endregion
        }
    }
    
}
