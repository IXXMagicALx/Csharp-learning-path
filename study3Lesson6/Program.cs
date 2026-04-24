using System.Runtime.CompilerServices;

namespace Lesson6
{
    class Array
    {
        private int[] arr;
        private int Length;//实际数组的长度
        private int capacity;//数组的容量
        public void Init()
        {
            Length = 0;//实际数组的长度
            capacity = 5;//数组的容量
            arr = new int[capacity];
        }
        public void PrintInfo()
        {
            Console.WriteLine("当前数组有{0}个数,容量为{1}", Length,capacity);
            for(int i = 0; i < Length ; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }  
        //增
        public void Add(int value)
        {
            arr[Length] = value;
            Length++;
            if(Length == capacity)//当要满的时候就要扩容
            {
                capacity *= 2;//容量翻一倍
                int [] tempArr = new int[capacity];//临时数组 
                for(int i = 0; i < Length ; i++)
                {
                    //老东西放进新房
                    tempArr[i] = arr[i];
                }
                arr = tempArr;//新房改名
            }
        }
        //删
        public void ReMove(int value)
        {
            //先遍历找到索引
            for(int i = 0;i < Length ; i++)
            {
                if (arr[i] == value)
                {
                    ReMoveAt(i);
                    return;
                }
            }
                Console.WriteLine("没有找到这个数");
        }
         void ReMoveAt(int index)
        {
            for(int i = index ; i < Length -1 ; i++)
            {
                arr[i] = arr[i + 1];//后面的往前移
            }
            Length--;
        }
        //查改
        public int this[int index]
        {
            get
            {
                if(null == arr || index > Length)
                {
                    Console.WriteLine("数组中没有在此位置的数");
                    return 0;
                }
                else
                {
                    return arr[index];
                } 
            }
            set
            {
                if(null == arr || index > Length)
                {
                    Console.WriteLine("数组中没有在此位置的数,无法修改");
                }
                else
                {
                    arr[index] = value;
                }

            }
        }
    }    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器");
            
            Array a = new Array();
            a.Init();
            a.Add(100);
            a.Add(200);
            a.Add(300);
            a.Add(400);
            a.Add(500);

            a.PrintInfo();//打印数组的信息
            a.ReMove(600);
            a.ReMove(300);
            a.PrintInfo();//打印数组的信息
            Console.WriteLine("你要查数组中第几位数？");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("是{0}", a[index-1]);
            Console.WriteLine("你要改它吗？（输入要修改的数即可)");
            a[index-1] = int.Parse(Console.ReadLine());
            a.PrintInfo();//打印数组的信息
        }
    }
}
    
