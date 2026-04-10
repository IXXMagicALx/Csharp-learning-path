namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");
            #region 交错数组的申明
            int[][] arr1;
            int[][] arr2 = new int[3][];
            int[][] arr3 = new int[3][] {new int[]{1,2,3},
                                         new int[]{4,5,},
                                         new int[]{6,7,8}};
            int[][] arr4 = new int[][] { new int[] {9,10,11 }, 
                                         new int[] {12,13 } , 
                                         new int[] {14 } };
            int[][] arr5 = { new int[] { 1, 0, 1 }, 
                             new int[] { 0, 1, 0 }, 
                             new int[] { 1, 2 }  };
            #endregion
            #region 获得数组的长度
            //获得行数
            int hangshu= arr5.GetLength(0);
            //获得2行对应的列数
            int lieshu = arr5[2].Length;
            Console.WriteLine("行数为{0}，第3行的数组有{1}个元素",hangshu,lieshu);
            #endregion
            #region 获得交错数组的元素
            Console.WriteLine(arr5[2][1]);
            #endregion
            #region 修改交错数组的元素
            arr5[0][1] = 1;
            #endregion
            #region 遍历交错数组
            for (int i=0; i< hangshu ;i++)
            {
                for (int j = 0; j < arr5[i].Length; j++)//注意此处j的范围
                {
                    Console.Write(arr5[i][j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion
            Console.WriteLine("****************************************************");
            #region 增加交错数组
            int [][] arr6 =new int [4][];//四行交错数组
            for (int i = 0; i < hangshu; i++)
            {
                arr6[i] = new int[arr5[i].Length];//给arr6在每行都创建一个一维数组
                for (int j = 0; j < arr5[i].Length; j++)//注意此处j的范围
                {
                    arr6[i][j] = arr5[i][j];
                }
            }
            arr5 = arr6;
            arr5[3] = new int[] { 6, 7, 8, 9 };//增加值加一维数组，而不能加单独元素
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5[i].Length; j++)//注意此处j的范围
                {
                    Console.Write(arr5[i][j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion
            Console.WriteLine("****************************************************");
            #region 减少交错数组
            int[][]arr7 = new int[2][];//小的交错数组
            for (int i=0;i<arr7.GetLength(0);i++)
            {
                arr7[i] = new int[arr5[i].Length];//给arr7在每行都创建一个一维数组
                for (int j=0;j<arr5[i].Length;j++)
                {
                    arr7[i][j] = arr5[i][j];
                }
            }
            arr5 = arr7;
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5[i].Length; j++)//注意此处j的范围
                {
                    Console.Write(arr5[i][j] + " ");
                }
                Console.WriteLine("");
            }
            #endregion
            #region 查找交错数组中的元素
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5[i].Length; j++)//注意此处j的范围
                {
                    if (arr5[i][j] == 0)
                    {
                        Console.WriteLine("0所在的位置是第{0}行第{1}列",i+1,j+1);
                    }
                }
                Console.WriteLine("");
            }
            #endregion
        }
    }
}
