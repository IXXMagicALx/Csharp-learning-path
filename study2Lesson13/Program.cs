namespace Lesson13
{
    internal class Program
    {
        #region 升降序函数
        static int[] ADSort( int[] arr1,bool AoD)
        //不需要ref和out是因为，没有新增数，也就没有新开区域只是在堆区原有数据修改排序，就不需要
        {

            bool isSort = false;
            bool order;
            for (int j = 0; j < arr1.Length; j++)
            {
                isSort = false;
                for (int i = 0; i < arr1.Length - 1-j; i++)
                {
                    //AoD为真，升序排列；AoD为假，降序排列
                    order = (AoD ? arr1[i] > arr1[i + 1] : arr1[i] < arr1[i + 1]);
                    if (order)
                    {
                        isSort = true;
                        int temp = arr1[i];
                        arr1[i] = arr1[i + 1];
                        arr1[i + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }

            }
            return arr1;
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序");
            #region 知识点
            //int[] arr = new int[]{6,5,3,6,6,1,9,4,7};

            //for (int m = 0; m <arr.Length; m++)
            //{
            //    //m轮，有几个数进行几轮
            //    //Length-1防止n到最后加1溢出,-m是为了每一轮过后最后固定位置的数不比较节约性能
            //    for (int n = 0; n < arr.Length - 1-m; n++)
            //    {
            //        //一轮比较
            //        if (arr[n] > arr[n + 1])
            //        {
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //}
            //for(int i = 0; i < arr.Length; i++)//遍历数组
            //{
            //    Console.Write(arr[i]+" ");
            //}

            ////终极性能优化
            //bool isSort = false;
            //for (int m = 0; m < arr.Length; m++)
            //{
            //    //m轮，有几个数进行几轮
            //    isSort = false;//默认认为不需要比较，且每一轮重置
            //    for (int n = 0; n < arr.Length - 1; n++)//Length-1防止n到最后加1溢出
            //    {
            //        //一轮比较
            //        if (arr[n] > arr[n + 1])
            //        {
            //            isSort = true;//true说明进行了比较，没有在最终状态
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //    if (!isSort)
            //    {
            //        break;//跳出外层的for循环
            //    }
            //}
            
            //for (int i = 0; i < arr.Length; i++)//遍历数组
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
        #region 题1
        int[] arr0 = new int[20];
            Random r = new Random();
        for (int i = 0; i < arr0.Length; i++)//给数组数
        {
                arr0[i]=r.Next(0,101);
        }
        for (int i = 0; i < arr0.Length; i++)//打印数组
        {
                Console.Write(arr0[i] + " "); 
        }
            Console.WriteLine("");//换行    
            #region 升序
            bool isSort = false;
            for (int m = 0; m < arr0.Length; m++)
            {
                isSort = false;//每轮默认false
                for (int n = 0; n < arr0.Length - 1- m; n++)
                {
                    
                    if (arr0[n] > arr0[n + 1])
                    {
                        isSort = true;
                        int temp = arr0[n];
                        arr0[n] = arr0[n + 1];
                        arr0[n + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            Console.Write("升序：");
            for (int i = 0; i < arr0.Length; i++)//打印数组
            {
                Console.Write(arr0[i] + " ");
            }
            #endregion
            Console.WriteLine("");//换行
            #region 降序
            for (int m =0 ; m<arr0.Length ; m++)
            {
                isSort = false;
                for (int n = 0; n < arr0.Length - 1-m; n++)
                {
                    if (arr0[n] < arr0[n + 1])
                    {
                        isSort = true;
                        int temp = arr0[n];
                        arr0[n] = arr0[n + 1];
                        arr0[n + 1] = temp;
                    }
                }
                if (!isSort)
                {
                    break;
                }
            }
            Console.Write("降序：");
            for (int i = 0; i < arr0.Length; i++)//打印数组
            {
                Console.Write(arr0[i] + " ");
            }

            #endregion
            #endregion
            #region 题2 用函数实现数组排序
            int[] arr1 = new int[10] { 88, 1, 2, 3, 99, 7, 100, 20, 30, 4 };
            bool AoD = true;//AoD为真，升序排列；AoD为假，降序排列
            Console.WriteLine("");
            ADSort(arr1,AoD);
            Console.Write("{0}序排序的结果是：",AoD?"升":"降");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+" ");//打印数组
            }
            Console.WriteLine();

            #endregion
        }
    }
}
