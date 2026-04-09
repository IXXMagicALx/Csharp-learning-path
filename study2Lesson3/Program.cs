using System.Diagnostics.CodeAnalysis;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组");
            #region 课
            ////二维数组的申明
            //int[,] arr;
            //int[,] arr1 = new int[3, 3];
            //int[,] arr2 = new int[3, 3] { { 1,2,3 },
            //                              { 4,5,6 },
            //                              { 7,8,9 } };
            ////二维数组的使用
            ////获取长度
            //Console.WriteLine(arr1.GetLength(0));//行数
            //Console.WriteLine(arr1.GetLength(1));//列数
            ////获取数组中元素
            //Console.WriteLine(arr1[0, 0]);
            ////修改数组的元素
            //arr1[1, 1] = 99;
            ////遍历二维数组
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr1[i, j]);
            //    }
            //}
            //Console.WriteLine("***************************");
            ////删除数组中元素
            //int[,]arr3=new int[3,2];
            //for (int i = 0;i < arr1.GetLength(0); i++)
            //{
            //    for(int j = 0;j < arr3.GetLength(1); j++)//改变在这里
            //    {
            //        arr3[i, j] = arr1[i, j];
            //    }
            //}
            //arr1 = arr3;
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j= 0;j<arr1.GetLength(1);j++)
            //    {
            //        Console.Write(arr1[i, j]+" ");
            //    }
            //    Console.WriteLine("");//换行
            //}
            #endregion
            #region 1.
            //int a = 0;
            //int[,] arr1 = new int[100, 100];
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        a++;
            //        arr1[i, j] = a;
            //        Console.Write(arr1[i, j] + " ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("*************************************************");
            #endregion
            #region 2.
            //Random r = new Random();
            //int[,] arr2 = new int[4, 4];
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        int a = r.Next(1, 101);
            //        arr2[i, j] = a;
            //        if ((i == 0 || i == 1) && (j == 2 || j == 3))//右上置零（i<=1&&j>=2）
            //        {
            //            arr2[i, j] = 0;
            //        }
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine(" ");//换行
            //}
            #endregion
            #region 3.
            ////别忘了右上角到左下角的对角线
            //int[,] arr3 = new int[3, 3];
            //Random r = new Random();
            //int sum = 0;
            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        int a = r.Next(1, 11);
            //        arr3[i, j] = a;
            //        Console.Write(arr3[i, j] + " ");
            //        if (i == j||i+j== arr3.GetLength(0)-1)//左上角到右下角的对角线
            //        {
            //            sum += arr3[i, j];
            //        }
            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("对角线的数之和是{0}", sum);//注意：不会重复加arr3[1,1]所以不需要单独减去一个arr3[1,1]
            #endregion
            #region 4.求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            //int max = 0;
            //int[,] arr4 = new int[5, 5];
            //Random r = new Random();
            //int adx = 0, ady = 0;
            //for (int i = 0; i < arr4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr4.GetLength(1); j++)
            //    {
            //        int a = r.Next(1, 501);//1~500
            //        arr4[i, j] = a;
            //        Console.Write(arr4[i, j] + " ");//打印二维数组
            //        if (i == 0 && j == 0)
            //        {
            //            max = arr4[0, 0];
            //        }
            //        if (arr4[i, j] > max)
            //        {
            //            max = arr4[i, j];
            //        }
            //        //存地址
            //        if (max == arr4[i, j])
            //        {
            //            adx = i + 1;//加1是为了符合日常所说的从1开始而不是从0开始
            //            ady = j + 1;
            //        }
            //    }
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("最大元素值是{0}，它在第{1}行第{2}列", max, adx, ady);
            #endregion
            #region 5*.给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
            Random r = new Random();
            int adx = 0, ady = 0;//是1的坐标
            int M = r.Next(1, 10);//二维数组行数
            int N = r.Next(1, 10);//二维数组列数
            bool [] hang = new bool[M];//默认为flase
            bool [] lie = new bool[N];//默认为flase
            int [,] arr5 = new int[M, N];
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    int x = r.Next(0, 2);//0和1
                    arr5[i, j] = x;
                    Console.Write(arr5[i, j] + " ");//打印变之前的
                    if (arr5[i, j] == 1)//含有1的行和列全部置1
                    {
                        //用bool一维数组标记哪些要变,要变1就置true
                        hang[i] = true;
                        lie[j] = true;
                    }
                }
                Console.WriteLine("");//换行
            }
            Console.WriteLine("************************************************");
            //变1
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])//满足行列的标识 是true就变1
                    {
                        arr5[i, j] = 1;
                        Console.Write(arr5[i, j] + " ");//打印变之后的
                    }
                }
                Console.WriteLine("");//换行
            }
            #endregion
        }
    }
}
