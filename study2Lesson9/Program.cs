namespace Lesson9
{
    internal class Program
    {
        #region 知识点
        //params只能配合一维数组使用
        static void Sum(int b, int a = 3,params int[]arr)//可以有多种参数，但是变长参数必须写在最后
        //两个参数b，a。其中a为可选参数，b为普通参数，所以a要写在b之后。
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(a + " " + b + " " + sum);//结果应该为2 1 6  
        }
        #endregion
        #region 习题
        static float [] Calculate(params int[] arr)//变长参数
        {
            float sum = 0F;
            float avg0 = 0F;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            } 
            avg0 = sum / arr.Length;
            return new float[] { sum, avg0 };
        }
        static int [] CalculateSum(params int[] arr)//变长参数
        {
            int sumEven = 0, sumOdd = 0;  
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i]%2==0)//偶数求和
                {
                    sumEven += arr[i];
                }
                else//奇数求和
                {
                    sumOdd += arr[i];
                }
            }
            return new int[] { sumEven, sumOdd };
        }
        #endregion
        static void Main(string[] args)
        {
            #region 知识点
            //Console.WriteLine("变长参数和参数默认值");
            //int[] arr = { 1, 2, 3 };
            //Sum(1, 2, arr);
            #endregion
            #region 1.求多个数字的和以及平均数
            //int[] arr1 = { 5, 6, 7 };
            //float[] arr = Calculate(arr1);//与函数内的相配合 == float [] arr = new float [] { sum , avg0 };相当于申明数组
            //Console.WriteLine("总和是：{0},平均值是：{1}", arr[0], arr[1]);
            #endregion
            #region 2.求多个数字的偶数和奇数和
            #region 给一个随机数数组
            Random r = new Random();
            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length; i++)
            {
                int a = r.Next(1,50);
                arr2[i] = a;
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("");
            #endregion
            int[] arr3 = CalculateSum(arr2);
            Console.WriteLine("这个数组所有偶数的和是：{0}，所有奇数的和是：{1}", arr3[0], arr3[1]);

            #endregion



        }
    }
}
